import numpy
import tensorflow as tf
import random
import json
import pickle

import nltk
from nltk.stem.lancaster import LancasterStemmer
stemmer = LancasterStemmer()

nltk.download('punkt')

with open("data.pickle", "rb") as f:
        words, labels, training, output = pickle.load(f)

with open("intents.json") as file:
    data = json.load(file)

model = tf.keras.models.load_model('chatbot_model.h5')

def bag_of_words(s, words):
    bag = [0 for _ in range(len(words))]

    s_words = nltk.word_tokenize(s)
    s_words = [stemmer.stem(word.lower()) for word in s_words]

    for se in s_words:
        for i, w in enumerate(words):
            if w == se:
                bag[i] = 1
            
    return numpy.array(bag)

def chat():
    print("Start talking with the bot (type quit to stop)!")
    while True:
        inp = input("You: ")
        if inp.lower() == "quit":
            break

        results = model.predict(numpy.array([bag_of_words(inp,words)]))
        results_index = numpy.argmax(results)
        tag = labels[results_index]

        arr = []
        for x in results:
          arr.extend(x)

        for tg in data["intents"]:
              if tg['tag'] == tag:
                  responses = tg['responses']
                  print(random.choice(responses))

chat()