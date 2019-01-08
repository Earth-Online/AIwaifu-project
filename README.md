# AIwaifu-project Development manual
AIwaifu project AI助(老)手(婆)计划 开发手册.md

base on machine learning

# 开发手册/理论实现 It's just a theory :)
### site for learn more
[中文分词常用算法](https://dsqiu.iteye.com/blog/1704960)

### 训练数据
与沙雕网友的全部对话(5.5w条 qq记录.txt) parser-> 消息数据库

### 无监督训练 单词-词典网络化 统计学思想 word&dict network
以最大字符(atom char)割词+词频统计 也许采用算法？ N-gram HMM -> 

可变lexical SPARQL数据库/抽象高维空间 w2v实现？(循环割词检查词频，组建更小的单词网络，直至index=0)(单词网络)

### 面向会话(session)建模 -> 上下文联想
将每个用户新建一个会话session -> 多线程处理session 查询SPARQL数据库

( 对词典网络进行人工标注？[情感 emotion？浅模拟](http://saifmohammad.com/WebPages/lexicons.html) ) -> 

遍历句子runFSM字符(atom)并给状态机 <单词网络之间的加权 ANN？？（组成词典网络系统）-> 添加新状态 ( 因果？？？/浅模拟人类个体状态 [参照ncase大佬的理论宇宙实现](https://ncase.me/OVC2016/) )

-> 状态机会话结束算法实现？（syntax实现）

#### 得到的SPARQL数据库（词典可视化vis/标注）与 AI状态机（需前面全部实现再测试）-> 语言分析与特征提取

### TODOLIST
网络结构数据库 maybe SPARQL数据库 or 抽象高维空间集合？

## about this?
NLP和这个NLU设计理念是不一样的，对话chatbot和单文本NLP分析情况并不能适用

### thinking about
WS中文分词 -> 单词&POS词性标注&NER命名实体识别		X句子脱离成单词，本身毫无意义

-> DP依存句法分析 -> AST ? 然后？？？

## something else
just monika :)

词义联想 word2vec

上下文联想 ltsm RNN

AIML

lexical word 词法

syntax 语法

割词 parser -> AST 语法树

?问答系统 FSM(状态机)（简单）

Q->A

?聊天系统（复杂）

Q->A

QQ->A

Q->AA

