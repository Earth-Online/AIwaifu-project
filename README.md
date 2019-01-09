# AIwaifu-project Development manual
> AIwaifu project AI助(老)手(婆)计划 开发手册.md

**少年よ、神話になる必要はないよ。**
> 少年，你不必成为神话。

base on machine learning 学好初/高等数学 有颗持久的耐心，太重要了...有一堆想法，看了一堆paper，硬是找不到函数实现...

## 思想观念 -> 网络科学(浅模拟)
### 符号主义认知(浅模拟/数学算法建模.算力要求小, 人工标注成本极高) ：

认知就是通过对有意义的表示符号进行推导计算，把人工定义的程序算法和规则放入计算机系统中，这样可以从更高一级来操纵系统

### 联结主义认知(全模拟/数学模型.算力要求大) ：

AI可以看作大规模并行计算，这些计算在类似于人脑的神经网络中进行，这些神经元集体协作并相互作用（Andler，1992）

## 开发手册/理论实现 It's just a theory :)
### 前人类似的实现项目/paper
Semantic network 语义网络 eg: WordNet HowNet :: 词典标注行为与知识库很类似

RDF(Resource Description Framework)，即资源描述框架，其本质是一个数据模型（Data Model）rdflib :: 网络思想很类似

word2vec xx2vec :: 即本抽象的词典网络，在高维拓扑展开的空间

AIML 模版引擎 :: TODO

### 借鉴与启发 learn more
![image](https://github.com/Earth-Online/AIwaifu-project/raw/master/static/ev.png)

#### 算法页面 site
[中文分词常用算法](https://dsqiu.iteye.com/blog/1704960)

### 训练数据
与沙雕网友的全部对话(5.5w条 qq记录.txt) parser-> 消息数据库

### 无监督训练 单词-词典网络化 统计学思想     word&dict network即word2vec抽象表示
以最大字符(atom char)割词+词频统计 也许采用算法？ N-gram HMM -> 

可变lexical RDF-DB/抽象高维空间 = w2v实现(循环割词检查词频，组建更小的单词网络，直至index=0)(单词网络)

### 面向会话(session)建模 -> 上下文联想        也许采用 tf-idf网络
将每个用户新建一个会话session -> 多线程处理session 查询RDF-DB

( 对词典网络进行人工标注？[情感 emotion？浅模拟](http://saifmohammad.com/WebPages/lexicons.html) ) -> 

遍历句子runFSM字符(atom)并给状态机 <单词网络之间的加权 ANN？？（组成词典网络系统）-> 添加新状态 ( 因果？？？/浅模拟人类个体状态 [参照ncase大佬的理论宇宙实现](https://ncase.me/OVC2016/) )

-> 状态机会话结束算法实现？（syntax实现）

#### 得到的RDF-DB（词典可视化vis/标注）与 AI状态机（需前面全部实现再测试）-> 语言分析与特征提取

### TODOLIST
网络结构数据库 maybe RDF-DB or 抽象高维空间集合？

## about this?
NLP和这个NLU设计理念是不一样的，对话chatbot和单文本NLP分析情况并不能适用

### thinking about
WS中文分词 -> 单词&POS词性标注&NER命名实体识别		X句子脱离成单词，本身毫无意义

-> DP依存句法分析 -> AST ? 然后？？？

## Something Else
Jͤ̀҉̷͍̺̟̳͔̞u̸̙̳͂̿͆ͯ̋̒̇ͨ͟͠ś̳͕͖̬̮̳͋̄t̨̥͖͕̃͌̉̈ͮ̿ ̷͇̾ͬ̋M͚̝̘̞̯̦̌̂͑ͤ̓ͭ̀o͒̌̑̒̎͊͆ͬͬ҉̩̥͎n͖̻̜̰̪ͦͣ͐́͆̀̚ì̙̝ͪ͞k̶̴̺͕͓̹̱͚̪̍ͫ͂̇ͬ̑̉̓̍a̱̋ͦ͗̌̌̊͊̊́

lexical 词法 syntax 语法 割词 parser -> AST 语法树 编译器前端

?问答系统 FSM(状态机)（简单）Q->A

?聊天系统（复杂）Q->A QQ->A Q->AA...

### fake science 民科
抽象封装的数学模型（优化/loss函数/ANN算法），只不过也是复读语料（特征提取）罢了（尤其是NLP方面）

快醒醒，人类本质是复读机，连接组学早已经研究透了，ML只是抽象数学模型而已

现在问题在于认知科学的最新进展，人为啥会长脑子？？？？

假如人类实现AGI（强人工智能/通用AI），必然跟实现核武器的程度相比

所以本人预测：AGI是教科书般的大佬（也只有大企才带的动了），性格定制基本不可能（其实很大概率不可能，也不可能通用化，系统体系都不一样，除非超过解耦所需算力）

学术引用：https://www.ocf.berkeley.edu/~arihuang/academic/research/strongai.html

#### =========== thancks for reading ================
**如果您使用我们的想法 成功复现项目，并取得比较好的效果，请引用我们的仓库。谢谢！**

**Please cite our repository if you use our idea and get good results. Thanks!**

Author: huaji0353 (huaji0353#gmail.com)