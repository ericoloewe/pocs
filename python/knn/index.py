from sklearn.neighbors import KNeighborsClassifier
from sklearn import preprocessing

# creating labelEncoder
le = preprocessing.LabelEncoder()

# Assigning features and label variables
# First Feature
weather = ['Sunny', 'Sunny', 'Overcast', 'Rainy', 'Rainy', 'Rainy', 'Overcast',
           'Sunny', 'Sunny', 'Rainy', 'Sunny', 'Overcast', 'Overcast', 'Rainy']
# Second Feature
temp = ['Hot', 'Hot', 'Hot', 'Mild', 'Cool', 'Cool', 'Cool',
        'Mild', 'Cool', 'Mild', 'Mild', 'Mild', 'Hot', 'Mild']

# Label or target varible
play = ['No', 'No', 'Yes', 'Yes', 'Yes', 'No', 'Yes',
        'No', 'Yes', 'Yes', 'Yes', 'Yes', 'Yes', 'No']

# Converting string labels into numbers.
weather_encoded = le.fit_transform(weather)

print(weather_encoded)

# converting string labels into numbers
temp_encoded = le.fit_transform(temp)

print(temp_encoded)

label = le.fit_transform(play)

print(label)

# combinig weather and temp into single listof tuples
features = list(zip(weather_encoded, temp_encoded))

print(features)

model = KNeighborsClassifier(n_neighbors=3)

# Train the model using the training sets
model.fit(features, label)

# Predict Output
print(model.predict([[0, 2]]))  # 0:Overcast, 2:Mild

print(model.predict([[1, 1]]))  # 1:Rainy, 1:Hot

print(model.predict([[2, 0]]))  # 2:Sunny, 0:Cool

print(model.predict([[0, 0]]))  # 0:Overcast, 0:Cool
