# Floyd's Cycle-Finding Algorithm

The mathematical explanation for why the pointers meet at the cycle entrance.

## Setting Up Variables

Let's define some variables:

- Let's call the distance from the start of the linked list to the entrance of the cycle as `x`
- Let's call the distance from the cycle entrance to the meeting point as `y`
- Let's call the length of the cycle as `C`

## First Phase Analysis

In the first phase, when the slow and fast pointers meet:

- The slow pointer has traveled a distance of `x + y`
- The fast pointer has traveled a distance of `x + y + n*C` for some integer `n` (it has gone around the cycle `n` times)

Since the fast pointer moves twice as fast as the slow pointer, we know:

- Distance traveled by fast = 2 × (Distance traveled by slow)
- `x + y + n*C = 2(x + y)`
- `x + y + n*C = 2x + 2y`
- `n*C = x + y`
- `x = n*C - y`

## Second Phase Reasoning

Now, in the second phase:

- We reset the slow pointer to the start
- The fast pointer stays at the meeting point (at distance `x + y` from start)
- Both pointers move at the same speed

1. The slow pointer needs to travel a distance of `x` to reach the cycle entrance
2. The fast pointer is currently at position `x + y` from the start
3. To reach the cycle entrance, the fast pointer needs to travel:
   - Either forward by `n*C - y` (from our equation `x = n*C - y`)
   - Or equivalently, backward by `y` and then around the cycle `n-1` times

Since the fast pointer moves one step at a time, it will travel exactly `x` steps (which equals `n*C - y`) and reach the cycle entrance.

At this point, both pointers will be at the cycle entrance, which corresponds to our duplicate number.

## Concrete Example with Array [1,3,4,2,2]

Let's trace through our example:

- The implicit linked list is: 0→1→3→2→4→2→4→...
- The cycle is 2→4→2→...
- Cycle entrance is at index 2 (value 4)
- The duplicate number is 2

In this case:

- `x` = 2 (distance from start to cycle entrance)
- `y` = 1 (distance from cycle entrance to meeting point)
- `C` = 2 (length of cycle)

Let's verify: `x = n*C - y` → 2 = 1\*2 - 0 → This checks out!

This mathematical property is what guarantees that the two pointers will always meet at the entrance of the cycle, which represents our duplicate number.
