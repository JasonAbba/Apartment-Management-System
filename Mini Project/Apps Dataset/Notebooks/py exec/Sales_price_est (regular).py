import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

dataset = pd.read_csv('CutappsDS - Processed.csv')
X = dataset.iloc[:, :-1].values
y = dataset.iloc[:, -1].values

from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2, random_state = 0)

from sklearn.ensemble import RandomForestRegressor
regressor = RandomForestRegressor(n_estimators = 10, random_state = 0)
regressor.fit(X_train, y_train)

y_pred = regressor.predict(X_test)
np.set_printoptions(precision=2)

from sklearn.metrics import r2_score
r2_score(y_test, y_pred)


sp = regressor.predict([4, 0, 10, 1])
sp = sp[0]
print("Estimated sales price " + str(sp))
