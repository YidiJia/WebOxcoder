﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface IChallengeRecord
    {
        int getHaveAcceptCountById(int challengeId);
        challengeRecord getChallengeRecByChaIdAndCodEmail(int challengeId, String coderEmail);
        bool changeChallengeRecord(challengeRecord recordItem);
        bool acceptChallenge(int challengeId, String coderEmail);
        bool deleteChengeRecord(int challengeId, String coderEmail);
    }
}
