#coding:utf-8
import jieba
import pickle

from gensim import corpora

from gensim import models

if 0:
    with open("msgs.w2v", "rb") as fp:
        bow_corpus = pickle.load(fp)

else:
    seg_list = []
    precessed_corpus = []
    with open("msgs.csv", "r", encoding="utf-8") as fp:
        for i in range(500):
            cout = fp.readline()
            for c in jieba.cut(cout):
                seg_list.append(c)
            precessed_corpus.append(cout)
    
    dictionary = corpora.Dictionary(seg_list)
    bow_corpus = [dictionary.doc2bow(text) for text in precessed_corpus]
    pickle.dump(bow_corpus, "msgs.w2v")

tfidf = models.TfidfModel(bow_corpus)
strings = ["我", "草"]
string_bow = dictionary.doc2bow(strings)
string_tfidf = tfidf[string_bow]
print(string_bow)
print(string_tfidf)