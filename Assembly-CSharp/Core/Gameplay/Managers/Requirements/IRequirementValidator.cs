using System;
using System.Collections.Generic;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001194 RID: 4500
	[Token(Token = "0x2001194")]
	public interface IRequirementValidator
	{
		// Token: 0x06006AEB RID: 27371
		[Token(Token = "0x6006AEB")]
		bool Check(uint requirementId, UserData user);

		// Token: 0x06006AEC RID: 27372
		[Token(Token = "0x6006AEC")]
		bool CheckRestrictions(uint requirementId, UserData user);

		// Token: 0x06006AED RID: 27373
		[Token(Token = "0x6006AED")]
		bool CheckRestrictions(IList<RestrictionInfo> restrictionsInfo, UserData user);

		// Token: 0x06006AEE RID: 27374
		[Token(Token = "0x6006AEE")]
		bool CheckRestriction(RestrictionInfo restrictionInfo, TriggerValue triggerValue);

		// Token: 0x06006AEF RID: 27375
		[Token(Token = "0x6006AEF")]
		bool CheckPrice(ResourceSet price, UserData user);

		// Token: 0x06006AF0 RID: 27376
		[Token(Token = "0x6006AF0")]
		bool CheckPrice(uint requirementId, UserData user);

		// Token: 0x06006AF1 RID: 27377
		[Token(Token = "0x6006AF1")]
		bool CheckMaterials(uint requirementId, UserData user);

		// Token: 0x06006AF2 RID: 27378
		[Token(Token = "0x6006AF2")]
		bool CheckMaterials(RepeatedField<RewardInfo> materials, UserData user);
	}
}
