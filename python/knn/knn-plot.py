import numpy as np
import matplotlib.pyplot as plt
from matplotlib.colors import ListedColormap

from sklearn.neighbors import KNeighborsClassifier
from sklearn import preprocessing

n_neighbors = 3

# creating labelEncoder
le = preprocessing.LabelEncoder()

cmap_light = ListedColormap(['orange', 'cyan', 'cornflowerblue'])
cmap_bold = ListedColormap(['darkorange', 'c', 'darkblue'])

# Assigning features and label variables
# First Feature
felling = ['Feliz', 'Feliz', 'Feliz', 'Triste', 'Triste', 'Feliz', 'Triste',
           'Feliz', 'Feliz', 'Triste', 'Triste', 'Feliz', 'Feliz', 'Triste']

# Second Feature
activity = ['Dirigindo', 'Lazer', 'Trabalhando', 'Trabalhando', 'Lazer', 'Dirigindo', 'Lazer',
            'Treinando', 'Jogando', 'Trabalhando', 'Trabalhando', 'Lazer', 'Lazer', 'Lazer']

# Label or target varible
genres = ['Eletronica', 'Funk', 'Funk', 'Rock', 'Rock', 'Eletronica', 'Pop',
          'Eletronica', 'Eletronica', 'Pop', 'Pop', 'Pop', 'Pop', 'Rock']

# Converting string labels into numbers.
felling_encoded = le.fit_transform(felling)
activity_encoded = le.fit_transform(activity)

print(felling_encoded)
print(activity_encoded)

label = le.fit_transform(genres)

print(label)

# combinig weather and temp into single listof tuples
features = list(zip(felling_encoded, activity_encoded))

print(features)

h = 1  # step size in the mesh

for weights in ['uniform', 'distance']:
    model = KNeighborsClassifier(n_neighbors=n_neighbors)

    # Train the model using the training sets
    model.fit(features, label)

    # Plot the decision boundary. For that, we will assign a color to each
    # point in the mesh [x_min, x_max]x[y_min, y_max].
    x_min, x_max = felling_encoded.min() - 1, felling_encoded.max() + 1
    y_min, y_max = activity_encoded.min() - 1, activity_encoded.max() + 1
    xx, yy = np.meshgrid(np.arange(x_min, x_max, h),
                         np.arange(y_min, y_max, h))

    # Predict Output
    # Z = model.predict([[0, 2]]) # 0:Feliz, 2:Lazer
    Z = model.predict(np.c_[xx.ravel(), yy.ravel()])
    
    # Put the result into a color plot
    Z = Z.reshape(xx.shape)
    print(Z)
    plt.figure()
    plt.pcolormesh(xx, yy, Z, cmap=cmap_light)

    # Plot also the training points
    plt.scatter(felling_encoded, felling_encoded, c=activity_encoded, cmap=cmap_bold,
                edgecolor='k', s=20)
    plt.xlim(xx.min(), xx.max())
    plt.ylim(yy.min(), yy.max())
    plt.title("3-Class classification (k = %i, weights = '%s')"
              % (n_neighbors, weights))


plt.show()
