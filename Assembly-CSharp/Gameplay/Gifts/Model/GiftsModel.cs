using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Gifts.Model
{
	// Token: 0x0200070C RID: 1804
	[Token(Token = "0x200070C")]
	public class GiftsModel : AbstractModel
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B26 RID: 11046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		public UserData TargetUser
		{
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0x7BC0", Offset = "0x7BC0", VA = "0x7BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B26")]
			[Address(RVA = "0x7BC1", Offset = "0x7BC1", VA = "0x7BC1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B28 RID: 11048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000835")]
		public SocialGiftDic[] Gifts
		{
			[Token(Token = "0x6002B27")]
			[Address(RVA = "0x7BC2", Offset = "0x7BC2", VA = "0x7BC2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B28")]
			[Address(RVA = "0x7BC3", Offset = "0x7BC3", VA = "0x7BC3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B2A RID: 11050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000836")]
		public IList<ulong> UsersGifted
		{
			[Token(Token = "0x6002B29")]
			[Address(RVA = "0x7BC4", Offset = "0x7BC4", VA = "0x7BC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B2A")]
			[Address(RVA = "0x7BC5", Offset = "0x7BC5", VA = "0x7BC5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x17000837")]
		public int GiftsSent
		{
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x7BC6", Offset = "0x7BC6", VA = "0x7BC6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x17000838")]
		public int MaxSendGifts
		{
			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x7BC7", Offset = "0x7BC7", VA = "0x7BC7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x17000839")]
		public int GiftsLeft
		{
			[Token(Token = "0x6002B2D")]
			[Address(RVA = "0x7BC8", Offset = "0x7BC8", VA = "0x7BC8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083A")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x7BC9", Offset = "0x7BC9", VA = "0x7BC9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B2F")]
			[Address(RVA = "0x7BCA", Offset = "0x7BCA", VA = "0x7BCA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083B")]
		public IGame Game
		{
			[Token(Token = "0x6002B30")]
			[Address(RVA = "0x7BCB", Offset = "0x7BCB", VA = "0x7BCB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B31")]
			[Address(RVA = "0x7BCC", Offset = "0x7BCC", VA = "0x7BCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x7BCD", Offset = "0x7BCD", VA = "0x7BCD", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Gifts_Model_GiftsModel__Dispose
		               (int param1,undefined4 param2,int *param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a226 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_SocialGiftDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_SocialGiftDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_SocialGiftDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SocialGiftDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_SocialGiftDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_Model_GiftsModel___c___ctor_b__27_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_Model_GiftsModel___c___ctor_b__27_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		    DAT_ram_00a5a226 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(int **)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811e9414;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e9414:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  uVar3 = *(undefined4 *)(iVar6 + 0xbc);
		  if (*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar4[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    iVar6 = unnamed_function_1417(System_Func_SocialGiftDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar6,uVar5,Method_Gameplay_Gifts_Model_GiftsModel___c___ctor_b__27_0__,0);
		    *(int *)(*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar6,Method_System_Linq_Enumerable_Where_SocialGiftDic___);
		  if (*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar4[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    iVar6 = unnamed_function_1417(System_Func_SocialGiftDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar5,Method_Gameplay_Gifts_Model_GiftsModel___c___ctor_b__27_1__,0);
		    *(int *)(*(int *)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c) + 8) = iVar6;
		  }
		  uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar3,iVar6,Method_System_Linq_Enumerable_OrderBy_SocialGiftDic__uint___);
		  uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_SocialGiftDic___);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x7BCE", Offset = "0x7BCE", VA = "0x7BCE")]
		public GiftsModel(IGame game, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x7BCF", Offset = "0x7BCF", VA = "0x7BCF")]
		public void SetUsersGifted(IList<ulong> usersList)
		{
		/* --- GHIDRA: SetUsersGifted ---
		void Gameplay_Gifts_Model_GiftsModel__SetUsersGifted(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a227 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		    DAT_ram_00a5a227 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Gifts_Model_GiftsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_UsersGifted ---
		undefined4 Gameplay_Gifts_Model_GiftsModel__set_UsersGifted(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e96bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811e96bb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_GiftsSent ---
		undefined4 Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a225 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25317);
		    DAT_ram_00a5a225 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811e976a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811e976a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_25317,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_MaxSendGifts ---
		int Gameplay_Gifts_Model_GiftsModel__get_MaxSendGifts(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  iVar2 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(param1,param1);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811e9829;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811e9829:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return iVar2 - iVar4;
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Gameplay_Gifts_Model_GiftsModel__set_Game(int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

}
