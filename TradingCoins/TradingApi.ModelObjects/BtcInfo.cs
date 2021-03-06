﻿using System.Collections.Generic;

namespace TradingApi.ModelObjects
{
   public static class BtcInfo
   {
      static BtcInfo()
      {
         SymbolMapHelper = new Dictionary<ExchangeSymbolEnum, ExchangeSymbolNameEnum>();
         SymbolMapHelper.Add(ExchangeSymbolEnum.btc,ExchangeSymbolNameEnum.bitcoin);
         SymbolMapHelper.Add(ExchangeSymbolEnum.ltc, ExchangeSymbolNameEnum.litecoin);
      }

      public static Dictionary<ExchangeSymbolEnum, ExchangeSymbolNameEnum> SymbolMapHelper;
      
      public enum PairTypeEnum
      {
         ltcbtc = 0,
         btcusd = 1,
         ltcusd = 2,
         ethusd = 3,
         ethbtc = 4
      }

      public enum ExchangeSymbolEnum
      {
         ltc = 0,
         btc = 1,
         usd = 2,
         eth = 3
      }

      public enum ExchangeSymbolNameEnum
      {
         bitcoin = 0,
         litecoin = 1
      }

      public enum ExchangeEnum
      {
         BITFINEX = 0
      }

      public enum BitfinexUnauthenicatedCallsEnum
      {
         pubticker = 0,
         stats = 1,
         trades = 2,
      }

      public enum BitfinexWalletEnum
      {
         trading = 0,
         exchange = 1,
         deposit = 2
      }

      public enum OfferDirectionEnum
      {
         lend = 0,
         loan = 1
      }

   }
}
