__author__ = 'Ricardo Valencia'

def wizeline(limit=100):
    for i in xrange(1, limit+1):
        # print only if comparison is True or fallback to i
        print("Wize"*(i%3==0) + "line"*(i%5==0) or i)

if __name__ == '__main__':
    wizeline()

