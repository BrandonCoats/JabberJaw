import nltk
from nltk.corpus import state_union
from nltk.tokenize import PunktSentenceTokenizer


class File:
    train_text = ""
    sample_text = ""
    
    def __init__(self):
        self.train_text = ""
        self.sample_text = ""
    # def __init__(self, train_text, sample_text):
    #   self.sample_text = sample_text
    #   self .train_text = train_text

    def get_train_text(self):
        return self.train_text

    def get_sample_text(self):
        return self.sample_text

    def read_file(self):
        try:
            f = open("trainText.txt", "r")
            self.train_text = f.readlines()
            self.sample_text = f.readlines()
            f.close()
        except Exception:
            print("Could not read file")

# train_text = state_union.raw("2005-GWBush.txt")
# sample_text = state_union.raw("2006-GWBush.txt")


training_file = File()


training_file.read_file()
training_text = training_file.get_train_text()
samples_text = training_file.get_sample_text()

custom_sent_tokenizer = PunktSentenceTokenizer(training_file)

tokenized = custom_sent_tokenizer.tokenize(samples_text)


def process_content():
    try:
        for i in tokenized[5:]:
            words = nltk.word_tokenize(i)
            tagged = nltk.pos_tag(words)
            named_ent = nltk.ne_chunk(tagged, binary=True)
            named_ent.draw()
    except Exception as e:
        print(str(e))


process_content()
