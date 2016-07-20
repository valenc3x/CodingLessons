
def check_ip(string=None):
    if string is None:
        return False
    sections = string.split(".")
    if len(sections) != 4:
        return False
    for sec in sections:
        try:
            if int(sec) < 0 or int(sec) > 255:
                return False
        except:
            return False
    return True

if __name__ == '__main__':
    assert check_ip('127.0.0.1'),       'Error!'
    assert not check_ip('Hello world'),     'Error!'
    assert not check_ip('127.0.False.1'),   'Error!'
    assert check_ip('0.0.0.0'),         'Error!'
    assert check_ip('255.255.255.255'), 'Error!'
    assert not check_ip('-1.255.255.255'),  'Error!'
    assert not check_ip('255.255.255.256'), 'Error!'
