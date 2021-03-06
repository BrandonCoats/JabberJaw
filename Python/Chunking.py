# this is the real stuff here grammer via
import nltk
from nltk.corpus import state_union
from nltk.tokenize import PunktSentenceTokenizer
# import sys
# print int(sys.argv[1]) + int(sys.argv[2])
train_text = state_union.raw("2005-GWBush.txt")
sample_text = state_union.raw("2006-GWBush.txt")

custom_sent_tokenizer = PunktSentenceTokenizer(train_text)

tokenized = custom_sent_tokenizer.tokenize(sample_text)


def process_content():
    try:
        for i in tokenized:
            words = nltk.word_tokenize(i)
            tagged = nltk.pos_tag(words)
            chunkGram = r"""Chunk: {<RB.?>*<VB.?>*<NNP>+<NN>?}"""
            chunkParser = nltk.RegexpParser(chunkGram)
            chunked = chunkParser.parse(tagged)
            chunked.draw()

    except Exception as e:
        print(str(e))


process_content()

# this retrievs the chucks and the non chunks as an array and rolls through them
# for subtree in chunked.subtrees():
#                print(subtree)

# this takes only the chunks , by lambda, please kill me now
# for subtree in chunked.subtrees(filter=lambda t: t.label() == 'Chunk'):
#               print(subtree)
