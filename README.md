# AIwaifu-project Development manual - journal
> AIwaifu project AI助(老)手(婆)计划 开发手册 - 日志.md

[![](https://img.shields.io/github/issues/Earth-Online/AIwaifu-project.svg)](https://github.com/Earth-Online/AIwaifu-project/issues)  [![](https://img.shields.io/github/forks/Earth-Online/AIwaifu-project.svg)](https://github.com/Earth-Online/AIwaifu-project/network) [![](https://img.shields.io/github/stars/Earth-Online/AIwaifu-project.svg)](https://github.com/Earth-Online/AIwaifu-project/stargazers) [![jaywcjlove/sb](https://jaywcjlove.github.io/sb/lang/chinese.svg)](README-CN.md)

**少年よ、神話になる必要はないよ。**
> 少年哟，你不必成为神话。[why?](https://www.myzaker.com/article/592d87241bc8e0a948000000/)

base on machine learning 学好初/高等数学 不计功利 耐心，太重要了...有一堆想法，看了一堆paper，硬是找不到函数实现...

## 思想观念 -> 网络科学(浅模拟)
### 符号主义认知(浅模拟/数学算法建模.算力要求小, 人工标注成本极高) ：

认知就是通过对有意义的表示符号进行推导计算，把人工定义的程序算法和规则放入计算机系统中，这样可以从更高一级来操纵系统

### 联结主义认知(全模拟/数学模型.算力要求大) ：

AI可以看作大规模并行计算，这些计算在类似于人脑的神经网络中进行，这些神经元集体协作并相互作用（Andler，1992）

## 开发手册/理论实现 It's just a theory :)
### 前人类似的实现项目/paper
Semantic network 语义网络 eg: WordNet HowNet :: 词典标注行为与知识库很类似

RDF(Resource Description Framework)，即资源描述框架，其本质是一个数据模型（Data Model）rdflib :: 网络思想很类似

word2vec xx2vec :: 即本抽象的词典网络，在高维的空间拓扑展开

AIML 模版引擎 :: TODO

### 借鉴与启发 learn more
![image](https://github.com/Earth-Online/AIwaifu-project/raw/master/static/ev.png)

#### 算法页面 site
[中文分词常用算法](https://dsqiu.iteye.com/blog/1704960)

### 训练数据
与沙雕网友的全部对话(5.5w条 qq记录.txt) parser-> 消息数据库

### 无监督训练 单词-词典网络化 统计学思想   即word2vec抽象表示
以最大字符(atom char)割词+词频统计 jieba训练不了自己的字典..坑.. -> 

割词算法 循环割词检查词频，组建更小的单词网络，直至index=0 已有有 N-gram HMM 实现

可变lexical (单词网络) RDF-DB/抽象高维空间 = w2v实现

### 面向会话(session)与FSM建模 -> 上下文联想    也许采用 tf-idf网络去实现？
将每个用户新建一个会话session -> 多线程处理session 翻译成句子向量数组

( 对词典网络/w2v进行人工标注[情感 emotion？浅模拟](http://saifmohammad.com/WebPages/lexicons.html) ) -> 

遍历句子runFSM字符(atom)并给状态机/预测chat的对象行为 <单词网络之间的加权 ANN？？（组成词典网络系统）/ 句子向量数组 -> 

============UPDATE TODO============

添加新状态 ( 因果？？？/浅模拟人类个体状态 [参照ncase大佬的理论宇宙实现](https://ncase.me/OVC2016/) ) -> 

状态机会话结束算法实现？（复现syntax）

#### 得到的RDF-DB（词典可视化vis/标注）与 AI状态机（需前面全部实现再测试）-> for 语言分析与特征提取

===================================

### TODOLIST
咱还是好好将ML这项技术拿来赚钱得了，脱离了生产力/现实的[理想乡/乌托邦](https://www.zhihu.com/question/48916690/answer/531264372)根本不存在

对于桌宠设计，问了群里一圈人，基本都是没啥概念的（反正你们只要乃子/妹子/卡哇伊..对吧...），本人同样觉得是个累赘，浪费资源（基于live2d技术实现）不谈，基于Windows怎么设计都是还妨碍日常（强迫症）。

哪怕这种东西(直球)实现了，也就火一段时间罢了，到了没人提起兴趣，当成理所当然的事的时候....而且框架还是被拆拿去通用/乱用

(人类本性，咱费力想出一种保护方法，都能随便想出n多种破解方法的（except 加密-信息学 头号玩家用的是区块链来着？），一些低素质国人开发者(我也是...是屑，我紫菜罢))...

## about this?
NLP和这个NLU设计理念是不一样的，对话chatbot和单文本NLP分析情况并不能适用

## 一些啥 Something Else
Jͤ̀҉̷͍̺̟̳͔̞u̸̙̳͂̿͆ͯ̋̒̇ͨ͟͠ś̳͕͖̬̮̳͋̄t̨̥͖͕̃͌̉̈ͮ̿ ̷͇̾ͬ̋M͚̝̘̞̯̦̌̂͑ͤ̓ͭ̀o͒̌̑̒̎͊͆ͬͬ҉̩̥͎n͖̻̜̰̪ͦͣ͐́͆̀̚ì̙̝ͪ͞k̶̴̺͕͓̹̱͚̪̍ͫ͂̇ͬ̑̉̓̍a̱̋ͦ͗̌̌̊͊̊́

lexical 词法 syntax 语法 割词 parser -> AST 语法树 编译器前端

WS中文分词 -> 单词&POS词性标注&NER命名实体识别 X句子脱离成单词，本身毫无意义 -> DP依存句法分析 -> AST ? 然后？？？

?问答系统 FSM(状态机)（简单）Q->A

?聊天系统（复杂）Q->A QQ->A Q->AA...

## 想啥呢 thinking about
### 民科 fake science
抽象封装的数学模型（优化/loss函数/ANN算法），只不过也是复读语料（特征提取/解耦再封装）罢了（尤其是NLP方面）

快醒醒！！人类本质是复读机，连接组学早已经研究透了，ML只是抽象数学模型而已（人脑也有算力极限的）

现在问题在于认知科学的最新进展，让我思考 人为啥会长脑子？？？？

假如人类实现AGI（强人工智能/通用AI），必然跟实现核武器的程度相比

所以本人预测：AGI是教科书般的大佬（也只有大企(指谷哥)才带的动了），性格定制基本不可能（其实很大概率不可能，也不可能通用化，系统体系都不一样，除非超过解耦所需算力）

学术引用：https://www.ocf.berkeley.edu/~arihuang/academic/research/strongai.html

### 哲学 Philosophy
保护某种IP（独占权）还是熵/焓/自然/现实/宇宙（不知道咋称呼）牛逼，封装行为特简单，解耦行为要的算力....

概念中的AI，现实中的代码，各种模块构成的吧 随便命名都没事。那人类的感官/组成，人又是个啥..................

动物都有交流语言，那么人类语言的含义/根源到底是什么？值得思考 

> 也只是给了个想法，咱的经历见识，看过这些东西也不知道您是啥感受，会去 和我一样看过番剧动画一样去思考吗？

> 模拟/预测观众思想：你说您:horse:呢，您真有趣，您当您是谁呢

#### 虽然都心知肚明 知道是无用功，但就是想写出来玩玩，瞎折腾 浪费时间也罢了...通俗话的不见黄泉不落泪吗2333

#### =========== so ... , thancks for reading ================
**如果您使用我们的想法 成功复现项目，并取得比较好的效果，请引用我们的仓库。谢谢！**

**Please cite our repository if you use our idea and get good results. Thanks!**

Author: huaji0353 (huaji0353#gmail.com)