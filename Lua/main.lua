function numericNormalization(x, min, max)
    local mag = (max - min) + 1
    x = (x - min) % mag + min
    if x < min then
        x = x + mag
    end
    return x
end

-- When min is 0 and max is 10

-- 0 is output
print(numericNormalization(0, 0, 10))

-- 5 is output
print(numericNormalization(5, 0, 10))

-- 10 is output
print(numericNormalization(10, 0, 10))

-- 10 is output
print(numericNormalization(-1, 0, 10))

-- 0 is output
print(numericNormalization(11, 0, 10))