from linked_list import SLL

def add_as_linked_list(one, two):
    assert isinstance(one, SLL)
    assert isinstance(two, SLL)

    base = 1
    number_1 = 0
    aux = one.head
    while aux:
        number_1 += (aux.value * base)
        base *= 10
        aux = aux.next

    base = 1
    number_2 = 0
    aux = two.head
    while aux:
        number_2 += (aux.value * base)
        base *= 10
        aux = aux.next

    result = number_1 + number_2
    list = SLL()
    base = 10
    while result > 0:
        residue = result % base
        list.add( residue )
        result = (result - (residue))//base
    return list




if __name__ == '__main__':
    one = SLL()
    one.add(1)
    one.add(5)
    two = SLL()
    two.add(9)
    two.add(4)
    resulting = add_as_linked_list(one, two)
    one.show_list()
    two.show_list()
    resulting.show_list()
