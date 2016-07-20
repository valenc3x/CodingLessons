from linked_list import SLL

def is_palindrome(nlist):
    mid = nlist.size // 2
    fhalf = list()
    lhalf = list()
    aux = nlist.head
    for _ in range(mid):
        fhalf.append(aux.value)
        aux = aux.next
    for _ in range(mid):
        lhalf.append(aux.value)
        aux = aux.next
    print(fhalf)
    print(lhalf)
    for i, j in zip(fhalf, reversed(lhalf)):
        if i != j:
            return False
    return True


if __name__ == '__main__':
    number = SLL()
    number.add(1)
    number.add(0)
    number.add(2)
    number.add(4)
    number.add(2)
    number.add(0)
    number.add(1)
    print(is_palindrome(number))
