# AIwaifu-project
AIwaifu project (AI老婆计划) Development manual

# 开发手册/理论实现
## 无监督
### 字符-词典网络化 统计学思想

统计词频 并以最大字符割词 也许算法？ N-gram HMM -> 可变lexical SPARQL数据库(无单词与单词连接)(循环割词检查词频，更小就新建更小的网络，直到index=0)(单词网络)

### 面向会话(session)建模
将每个用户新建一个会话session -> 多线程处理session 查询SPARQL数据库 (随机？) 

-词与词的网络加权（词典网络）-> 

遍历句子并给状态机 因果？？？/模拟人类个体行为 [参照一个宇宙的实现/如何在134个简单的步骤中模拟宇宙](https://ncase.me/OVC2016/)

添加新状态(提供情感标注接口？？对词典网络进行人工标注？？) 

-> 状态机会话结束算法实现？（syntax实现）

得到SPARQL数据库（词典可视化/无标注） 与 AI状态机（需前面全部实现再测试）

### TODOLIST
网络结构数据库 maybe SPARQL数据库

## about?
NLP和这个NLU设计理念是不一样的，对话chatbot和单文本NLP分析情况并不能适用

### thinking about
WS中文分词 -> 单词&POS词性标注&NER命名实体识别		X句子脱离成单词，本身毫无意义

-> DP依存句法分析 -> AST ? 然后？

## something else
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

