﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface IEnterprise
    {
        int getCount();
        IList<enterprise> getNotCheckedEnterprise();
        IList<enterprise> getSuccessCheckedEnterprise();
        IList<enterprise> searchEnterprise(String name);
        bool deleteEnterprise(enterprise enterpriseItem);
        bool modifyEnterprise(enterprise enterpriseItem);
        bool checkEnterprise(String enterpriseEmail);
        bool addEnterprise(enterprise enterpriseItem);
        enterprise getEnterpriseByEmail(String enterpriseEmail);
    }
}
