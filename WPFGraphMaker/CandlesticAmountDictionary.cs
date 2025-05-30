﻿namespace WPFGraphMaker
{
    public interface ICandlesticAmountDictionary
    {
        Dictionary<string, int> GetCandlestickAmount();
    }
    internal class CandlesticAmountDictionary: ICandlesticAmountDictionary
    {
        public Dictionary<string, int> GetCandlestickAmount()
        {
            return new Dictionary<string, int>()
            {
                {"Bearish2Crows",3 },
                {"Bearish3BlackCrows", 3 },
                {"Bearish3InsideDown", 3 },
                {"Bearish3OutsideDown",3 },
                {"Bearish3LineStrike",4 },
                {"BearishAdvanceBlock",3 },
                {"BearishBeltHold",2 },
                {"BearishBlackClosingMarubozu",1 },
                {"BearishBlackMarubozu",1 },
                {"BearishBlackOpeningMarubozu",1 },
                {"BearishBreakaway",5 },
                {"BearishDeliberation",3 },
                {"BearishDarkCloudCover",2 },
                {"BearishDojiStar",2 },
                {"BearishDownsideGap3Methods",3 },
                {"BearishDownsideTasukiGap",3 },
                {"BearishDragonflyDoji",1 },
                {"BearishEngulfing",2 },
                {"BearishEveningDojiStar",3 },
                {"BearishEveningStar",3 },
                {"BearishFalling3Methods",5 },
                {"BearishGravestoneDoji",2 },
                {"BearishHarami",2 },
                {"BearishIdentical3Crows",3 },
                {"BearishHaramiCross", 2 },
                {"BearishInNeck",2 },
                {"BearishKicking",2 },
                {"BearishLongBlackCandelstick",1 },
                {"BearishMeetingLines",2 },
                {"BearishOnNeck",2 },
                {"BearishSeparatingLines",2 },
                {"BearishShootingStar",2 },
                {"BearishSideBySideWhiteLines",3 },
                {"BearishThrusting",2 },
                {"BearishTriStar",3 },
                {"BearishTweezerTop",2 },
                {"BearishUpsideGap2Crows",3 },
                {"Bullish3InsideUp",3 },
                {"Bullish3OutsideUp",3 },
                {"Bullish3StarsintheSouth",3 },
                {"Bullish3WhiteSoldiers",3 },
                {"Bullish3LineStrike",4 },
                {"BullishBeltHold",2 },
                {"BullishBreakaway",5 },
                {"BullishConcealingBabySwallow",4 },
                {"BullishDojiStar",2 },
                {"BullishDragonflyDoji",1 },
                {"BullishEngulfing",2 },
                {"BullishGravestoneDoji",2 },
                {"BullishHarami",2 },
                {"BullishHaramiCross",2 },
                {"BullishHomingPigeon",2 },
                {"BullishInvertedHammer",2 },
                {"BullishKicking",2 },
                {"BullishLadderBottom",5 },
                {"BullishLongWhiteCandlestick",1 },
                {"BullishMatHold",5 },
                {"BullishMatchingLow",2 },
                {"BullishMeetingLines",2 },
                {"BullishMorningDojiStar",3 },
                {"BullishMorningStar",3 },
                {"BullishPiercingLine",2 },
                {"BullishRising3Methods",5 },
                {"BullishSeparatingLines",2 },
                {"BullishSideBySideWhiteLines",3 },
                {"BullishStickSandwich",3 },
                {"BullishTriStar",3 },
                {"BullishTweezerBottom",2 },
                {"BullishUnique3RiverBottom",3 },
                {"BullishUpsideGap3Methods",3 },
                {"BullishUpsideTasukiGap",3 },
                {"BullishWhiteClosingMarubozu",1 },
                {"BullishWhiteMarubozu",1 },
                {"BullishWhiteOpeningMarubozu",1 },
            };
        }
    }
}
