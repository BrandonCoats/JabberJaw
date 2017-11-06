import nltk
from nltk.corpus import state_union
from nltk.tokenize import PunktSentenceTokenizer
import sys

stuff = ""
train_text = sys.argv[0]
sample_text = sys.argv[1]

# the above are native files in the library for training
# below is the way to train the tokenizer

custom_sent_tokenizer = PunktSentenceTokenizer(train_text)

tokenized = custom_sent_tokenizer.tokenize(sample_text)


def process_content():
    try:
        # this line defines the
        for i in tokenized[:5]:
            words = nltk.word_tokenize(i)
            tagged = nltk.pos_tag(words)
            global stuff
            stuff = tagged
            print(tagged)
    except Exception as e:
        print(str(e))


process_content()

# print stuff
