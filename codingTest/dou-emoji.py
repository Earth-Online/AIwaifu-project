#coding:utf-8
import numpy as np
from keras.models import Sequential
from keras.layers import Dense

# ANN
model = Sequential([
    Dense(output_dim=1, input_dim=1),
])
'''model.add'''

# choose loss function and optimizing method
model.compile(loss='mse',optimizer='sgd') # 二次方误差，乱序训练优化
# loss 函数 (wx+b)^2

# traning
print("traning ----")


for step in range(3):
    QUS = np.array([input("I :>")])
    P_QUS = model.predict(QUS)
    model.train_on_batch(QUS, P_QUS)
    print("AI:>%s"%P_QUS)
    QUS = P_QUS
    ANS = np.array([input("I :>")])
    P_ANS = model.predict(ANS)
    model.train_on_batch(QUS, ANS)
    print("AI:>%s"%P_ANS)
    ANS = P_ANS