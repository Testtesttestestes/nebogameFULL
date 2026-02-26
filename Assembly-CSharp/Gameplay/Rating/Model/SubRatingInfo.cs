using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Rating.Model
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	public class SubRatingInfo
	{
		// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x7375", Offset = "0x7375", VA = "0x7375")]
		public SubRatingInfo(RatingKindTypeDic.Types.RatingKindType specId, UserRatingKindDic ratingKindDic)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Model_SubRatingInfo___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 0xc);
		  uVar1 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param3,0);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetTitle(param3,0);
		  uVar3 = Core_Extensions_Dict_CultRatingKindDicExt__GetIcon32AssetId(param3,0);
		  *(undefined1 *)(param1 + 0x1c) = *(undefined1 *)(param3 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Model_SubRatingInfo___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 0xc);
		  uVar1 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param3,0);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetTitle(param3,0);
		  uVar3 = Core_Extensions_Dict_CultRatingKindDicExt__GetIcon32AssetId(param3,0);
		  *(undefined1 *)(param1 + 0x1c) = *(undefined1 *)(param3 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Model_SubRatingInfo___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 0xc);
		  uVar1 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param3,0);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetTitle(param3,0);
		  uVar3 = Core_Extensions_Dict_CultRatingKindDicExt__GetIcon32AssetId(param3,0);
		  *(undefined1 *)(param1 + 0x1c) = *(undefined1 *)(param3 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Model_SubRatingInfo___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 0xc);
		  uVar1 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param3,0);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetTitle(param3,0);
		  uVar3 = Core_Extensions_Dict_CultRatingKindDicExt__GetIcon32AssetId(param3,0);
		  *(undefined1 *)(param1 + 0x1c) = *(undefined1 *)(param3 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002217")]
		[Address(RVA = "0x7376", Offset = "0x7376", VA = "0x7376")]
		public SubRatingInfo(RatingKindTypeDic.Types.RatingKindType specId, ClanRatingKindDic ratingKindDic)
		{
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002218")]
		[Address(RVA = "0x7377", Offset = "0x7377", VA = "0x7377")]
		public SubRatingInfo(RatingKindTypeDic.Types.RatingKindType specId, CultRatingKindDic ratingKindDic)
		{
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002219")]
		[Address(RVA = "0x7378", Offset = "0x7378", VA = "0x7378")]
		public SubRatingInfo(RatingKindTypeDic.Types.RatingKindType specId, uint kindId, string title, string description, string subRatingImageAssetId, bool enabled)
		{
		}

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x8")]
		public readonly RatingKindTypeDic.Types.RatingKindType SpecId;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint KindId;

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Title;

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x14")]
		public readonly string Description;

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x18")]
		public readonly string SubRatingImageAssetId;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0x1C")]
		public readonly bool Enabled;
	}
}
