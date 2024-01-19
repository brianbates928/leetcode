awk '
{
    # For each line (record in awk), iterate over each field
    for (i=1; i<=NF; i++)  {
        # Store each field in a two-dimensional array, a[NR,i]
        # NR is the current record number (line number)
        # i is the field number
        a[NR,i] = $i
    }
}
# If the number of fields in this line (NF) is greater than p, update p
# This is used to keep track of the maximum number of fields in any line
NF>p { p = NF }
END {    
    # At the end of all input, iterate over the array in column order
    for(j=1; j<=p; j++) {
        # Initialize str with the first field of the j-th column
        str=a[1,j]
        # Append the rest of the fields in the j-th column to str
        for(i=2; i<=NR; i++){
            str=str" "a[i,j];
        }
        # Print the transposed column, which is now a row
        print str
    }
}' file.txt
