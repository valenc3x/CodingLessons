from linked_list import SLL

def removing():
    sll = SLL()
    sll.add(1)
    sll.add(3)
    sll.add(1)
    sll.add(10)
    sll.add(2)
    sll.add(3)
    sll.add(10)
    sll.add(5)

    print(sll.size)
    sll.show_list()
    sll.remove_duplicates()
    print(sll.size)
    sll.show_list()

if __name__ == '__main__':
    removing()
