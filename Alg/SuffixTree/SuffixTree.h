class CSuffixTree
{
public: 
	CSuffixTree();
	~CSuffixTree();
	CSuffixTree *children[26];
	bool end[26];
	void CreateSuffixTree(char *input);
	void CreateSuffixTreeNode(char *input, CSuffixTree *node);
};