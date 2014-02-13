using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _004_SetConflictBit
    {
        /*
         * Give a list of events in the following structure. Set the conflict flag to true if the event
            conflicts with any other event in the list.

            class Event
            {
            int start;
            int end;
            bool conflict;
            }
         * http://www.mitbbs.com/article_t/JobHunting/32263975.html
         */
        // The basica idea is trying to build a interval tree, during the process building it flip 
        // the conflict bit.
        // the first sort of the list is make sure I am building a balance tree.
        public class Event
        {
            public int start;
            public int end;
            public bool conflict;
        }

        public class InterValeTreeNode
        {
            public Event Value;
            public int MaxChild;
            public InterValeTreeNode leftChild;
            public InterValeTreeNode rightChild;
        }

        public void ProcessConflicts(List<Event> events)
        {
            if (events == null || events.Count == 0)
            {
                return;
            }
            
            // Sort the list. make sure the tree is a balance tree.
            //events.Sort();

            InterValeTreeNode root = new InterValeTreeNode();
            int mid = events.Count/2;
            root.Value = events[mid];
            Worker(events, 0, mid - 1, root);
            Worker(events, mid + 1, events.Count - 1, root);
        }

        public void Worker(List<Event> events, int left, int right, InterValeTreeNode root)
        {
            if (left > right)
                return;
            int mid = (left + right) / 2;
            InterValeTreeNode tmp = root;
            while (tmp != null)
            {
                int totalLength = Math.Max(events[mid].end, tmp.Value.end) - Math.Min(events[mid].start, tmp.Value.start);

                if ( totalLength < (events[mid].end - events[mid].start + tmp.Value.end - tmp.Value.start ) )// overlap with tmp
                {
                    events[mid].conflict = true;
                    tmp.Value.conflict = true;
                }

                if (events[mid].start < tmp.Value.start)
                {
                    if (tmp.leftChild != null)
                    {
                        tmp = tmp.leftChild;
                    }
                    else
                    {
                        InterValeTreeNode node = new InterValeTreeNode()
                        {
                            Value = events[mid]
                        };
                        tmp.leftChild = node;
                        break;
                    }
                }
                else
                {
                    if (tmp.rightChild != null)
                    {
                        tmp = tmp.rightChild;
                    }
                    else
                    {
                        InterValeTreeNode node = new InterValeTreeNode()
                        {
                            Value = events[mid]
                        };
                        tmp.rightChild = node;
                        break;
                    }
                }
            }
            Worker(events, left, mid - 1, root);
            Worker(events, mid + 1, right, root);
        }
    }
}
