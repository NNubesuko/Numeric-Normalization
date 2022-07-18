# coding: utf-8

def numeric_normalization(x, min, max):
    mag = (max - min) + 1
    x = (x - min) % mag + min
    if x < min:
        x += mag
    return x


# When min is 0 and max is 10

# 0 is output
print(numeric_normalization(0, 0, 10))

# 5 is output
print(numeric_normalization(5, 0, 10))

# 10 is output
print(numeric_normalization(10, 0, 10))

# 10 is output
print(numeric_normalization(-1, 0, 10))

# 0 is output
print(numeric_normalization(11, 0, 10))