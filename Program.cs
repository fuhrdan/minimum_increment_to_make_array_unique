//***************************************************************
//** I used a hash table to keep track of the numbers    ********
//** that were unique and incremented new numbers to     ********
//** unique status                                       ********
//** By Dan Fuhr                                         ********
//***************************************************************
int minIncrementForUnique(int* nums, int numsSize) {
    int hash[250000] = {0};
    int answer = 0;

    for(int x = 0; x < numsSize; x++)
    {
        if(hash[nums[x]]==0)
        {
            hash[nums[x]]++;
        }
        else if(hash[nums[x]]==1)
        {
            while(hash[nums[x]]==1)
            {
                nums[x] = nums[x] + 1;
                answer = answer + 1;
            }
            hash[nums[x]]++;
        }
//        printf("nums[%d]=%d\n",x,nums[x]);
    }
    return answer;
}