print("안녕하세요"[0:1])
# 파이썬에서는 [0:1]은 범위가 0 <= x < 1
# 따라서 1을 포함하지 않는다.
print("안녕하세요"[0:2])
print("안녕하세요"[0:3])

print("안녕하세요"[2:]) # 하세요
print("안녕하세요"[:2]) # 안녕

print("안녕하세요"[-2:-1]) # 세
# [-1:-2]는 불가능