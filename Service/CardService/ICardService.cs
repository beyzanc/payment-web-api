﻿using ResiPay.Model.Card;
using ResiPay.DB.Entities;
using System.Collections.Generic;

namespace ResiPay.Service.CardService
{
    public interface ICardService
    {
        public BaseResult<CardViewModel> AddCard(CardInsertModel cardModel);
        public BaseResult<CardViewModel> GetCardByUserId(int userId);
        public BaseResult<CardViewModel> UpdateCard(CardInsertModel cardModel);
        public BaseResult<CardViewModel> DeleteCard(string id);
        public BaseResult<CardViewModel> GetCardByCardId(string id);
        public BaseResult<List<CardViewModel>> GetCards();

    }
}
