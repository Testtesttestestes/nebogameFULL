using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Data.Skills;
using Core.Dict;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Discounts.Model;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Model
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	public class GolemModel : AbstractModel
	{
		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042C2 RID: 17090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2F")]
		public SkillCollection GolemSkills
		{
			[Token(Token = "0x60042C1")]
			[Address(RVA = "0x9175", Offset = "0x9175", VA = "0x9175")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042C2")]
			[Address(RVA = "0x9176", Offset = "0x9176", VA = "0x9176")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060042C3 RID: 17091 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x17000D30")]
		public bool HeadUser
		{
			[Token(Token = "0x60042C3")]
			[Address(RVA = "0x9177", Offset = "0x9177", VA = "0x9177")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D31")]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x60042C4")]
			[Address(RVA = "0x9178", Offset = "0x9178", VA = "0x9178")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x9179", Offset = "0x9179", VA = "0x9179")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x917A", Offset = "0x917A", VA = "0x917A", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Buildings_Golem_Model_GolemModel__Dispose
		               (int param1,undefined4 param2,int *param3,undefined4 param4,undefined4 param5,
		               int param6,undefined4 param7)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 param4_00;
		  undefined4 param5_00;
		  longlong lVar5;
		  longlong lVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 param6_00;
		  undefined4 uVar9;
		  int iVar10;
		  int iVar11;
		  
		  if (DAT_ram_00a5785b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a5785b = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(int *)(param1 + 0x10) = param6;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  uVar9 = *(undefined4 *)(*(int *)(*(int *)(param6 + 0x10) + 0x38) + 0x20);
		  iVar11 = *param3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80de6b2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80de6b2b:
		  uVar9 = (**(code **)((ulonglong)*puVar2 * 4))(param3,uVar9,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = uVar9;
		  lVar5 = Gameplay_World_Model_ClanData__set_ClanCultDic
		                    (*(undefined4 *)(*(int *)(param6 + 0x10) + 0x30),0);
		  lVar6 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		  if (lVar5 == lVar6) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar11 = *piVar7;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x238);
		          goto code_r0x80de6c00;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80de6c00:
		    iVar11 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(iVar11 + 0x10);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar7;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xe0);
		        goto code_r0x80de6cb2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80de6cb2:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar1 = 0;
		  iVar11 = *piVar3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xf0);
		        goto code_r0x80de6d34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,6);
		code_r0x80de6d34:
		  uVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x158);
		        goto code_r0x80de6ddc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80de6ddc:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar4 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar4,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x160);
		        goto code_r0x80de6e8e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80de6e8e:
		  param4_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x178);
		        goto code_r0x80de6f3a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de6f3a:
		  param5_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar8 = *(undefined4 *)(param1 + 0x1c);
		  param6_00 = *(undefined4 *)(param1 + 8);
		  iVar11 = unnamed_function_1417(Gameplay_Clans_Buildings_Golem_Model_GolemInventoryModel_TypeInfo);
		  if (DAT_ram_00a57855 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57855 = '\x01';
		  }
		  Gameplay_Inventory_Model_InventoryBaseModel__get_TotalSlotsAvailable
		            (iVar11,uVar9,uVar4,param4_00,param5_00,param6_00,0);
		  *(undefined4 *)(iVar11 + 0x58) = uVar8;
		  iVar10 = *piVar7;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x120);
		        goto code_r0x80de7010;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80de7010:
		  iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  *(undefined4 *)(iVar11 + 0x10) = *(undefined4 *)(*(int *)(iVar10 + 0x10) + 0x10);
		  *(int *)(param1 + 0x14) = iVar11;
		  return;
		}
		*/

		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x917B", Offset = "0x917B", VA = "0x917B")]
		public GolemModel(IDictProvider dictProviderProvider, IUserCache userCache, UserData user, ClanWarsModel clanWarsModel, ClanIsle clanIsle)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Model_GolemModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5785c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5785c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x80de70ea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80de70ea:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(iVar3 + 0x18);
		  return;
		}
		*/

		}

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClanIsle ClanIsle;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x14")]
		public readonly GolemInventoryModel GolemInventoryModel;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClanWarsModel ClanWarsModel;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x1C")]
		public readonly UserData GolemUserData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_GolemSkills ---
		uint Gameplay_Clans_Buildings_Golem_Model_GolemModel__set_GolemSkills(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a5785a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5785a = '\x01';
		  }
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x10) + 0x30) + 0x14),0);
		  return (uint)(lVar1 == lVar2);
		}
		*/


		/* --- GHIDRA: set_DiscountHandler ---
		void Gameplay_Clans_Buildings_Golem_Model_GolemModel__set_DiscountHandler
		               (int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

}
