using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.Rating.Model
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public class RatingRequestDto
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x7373", Offset = "0x7373", VA = "0x7373")]
		public RatingRequestDto(RatingKindTypeDic.Types.RatingKindType kindType, uint type, RatingPeriods period)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Rating_Model_RatingRequestDto___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58069 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12358);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16540);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28690);
		    DAT_ram_00a58069 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28690,StringLiteral_16540,uVar1,0);
		  local_8 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = func_ii_1081(Protocol_Rating_RatingPeriods_TypeInfo,&local_8);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,StringLiteral_12358,uVar2,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,uVar2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x7374", Offset = "0x7374", VA = "0x7374", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Gameplay_Rating_Model_RatingRequestDto__ToString
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 0xc);
		  uVar1 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(param3,0);
		  uVar2 = Core_Extensions_Dict_UserRatingKindDicExt__GetButton128AssetId(param3,0);
		  uVar3 = Core_Extensions_Dict_UserRatingKindDicExt__GetIcon256AssetId(param3,0);
		  *(undefined1 *)(param1 + 0x1c) = *(undefined1 *)(param3 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  *(undefined4 *)(param1 + 8) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x8")]
		public readonly RatingKindTypeDic.Types.RatingKindType KindType;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint Type;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x10")]
		public readonly RatingPeriods Period;
	}
}
