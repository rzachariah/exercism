module Pangram (isPangram) where

import Data.Char

isPangram :: String -> Bool
isPangram text =  26 == length [ c | c <- ['A'..'Z'], c `elem` map toUpper text]
