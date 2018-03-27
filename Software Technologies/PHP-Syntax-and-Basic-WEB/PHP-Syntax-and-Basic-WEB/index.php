<?php
/**
 * Testing docker xdebug
 */
$variableOne = 1;
$variableTwo = 2;
$variableSumOfOneAndTwo = $variableOne + $variableTwo;

echo ($variableSumOfOneAndTwo === 3) ? $variableOne . ' plus ' . $variableTwo . ' equals ' . $variableSumOfOneAndTwo . '<br>':
                                        'Opppsss something is wrong'. PHP_EOL;



/**
 * Testing docker localhost
 */
echo "Docker server running".PHP_EOL;