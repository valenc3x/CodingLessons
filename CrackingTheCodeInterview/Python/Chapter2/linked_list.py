__author__ = 'valenc3x'

class Node(object):
    """docstring for Node"""
    def __init__(self, value):
        self.value = value
        self._next = None
        self._prev = None

    def __str__(self):
        return "{}".format(self.value)

    @property
    def next(self):
        return self._next

    @next.setter
    def next(self, node):
        assert isinstance(node, Node) or node is None
        self._next = node

    @property
    def prev(self):
        return self._prev

    @prev.setter
    def prev(self, node):
        assert isinstance(node, Node) or node is None
        self._prev = node

    def node_data(self):
        print("value: {} \t\t next: {} \t\t prev: {}".format(self.value, self.next, self.prev))

class SLL(object):
    """Simple Linked List"""

    def __init__(self):
        self.head = None

    @property
    def size(self):
        aux = self.head
        count = 0
        while aux:
            count += 1
            aux = aux.next
        return count

    def add(self, value):
        new_node = Node(value)
        if self.head is None:
            self.head = new_node
        else:
            aux = self.head
            while aux.next:
                aux = aux.next
            aux.next = new_node
        return new_node

    def remove_duplicates(self):
        unique = set()
        aux = self.head
        prev = None
        while aux:
            if aux.value in unique:
                prev.next = aux.next
            else:
                unique.add(aux.value)
                prev = aux
            aux = aux.next


    def show_list(self):
        result = list()
        aux = self.head
        while aux:
            result.append(str(aux))
            aux = aux.next
        print(' -> '.join(result))

    def sll_data(self):
        aux = self.head
        while aux:
            aux.node_data()
            aux = aux.next

