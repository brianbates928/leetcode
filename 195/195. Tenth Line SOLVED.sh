# Read from the file file.txt and output the tenth line to stdout.
# option 1
awk '{line[NR]=$0} END{if(NR<9){print ""} else {print line[10]}}' file.txt
# option 2
awk 'NR==10' file.txt
# option 3
sed -n '10p' file.txt
# head -10 file.txt | tail -1 this only works if guaranteed at least 10 lines
