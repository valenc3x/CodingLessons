
def anagrams(words=None):
    if words is None:
        return False
    order = dict()
    for word in words:
        wkey = "".join(sorted(word))
        if wkey in order:
            order[wkey].append(word)
        else:
            order[wkey] = list()
            order[wkey].append(word)

    for key in order:
        print(" - ".join(order[key]))

if __name__ == '__main__':
    words = ["AMOR","ARMO","ESPONJA","JAMON","JAPONES","MARO","MONJA","MOJAN","MORA","OMAR","RAMO","ROMA"]
    anagrams(words)

