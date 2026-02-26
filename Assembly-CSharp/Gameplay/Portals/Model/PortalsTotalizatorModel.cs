using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	public class PortalsTotalizatorModel : PortalsRatingModel
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C7")]
		public BetList CurrentBetList
		{
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x7543", Offset = "0x7543", VA = "0x7543")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x7544", Offset = "0x7544", VA = "0x7544")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x7545", Offset = "0x7545", VA = "0x7545")]
		public PortalsTotalizatorModel(UserData user, IGame game, IUserCache userCache)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C8")]
		public UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs[] UsersCache
		{
			[Token(Token = "0x60023F5")]
			[Address(RVA = "0x7546", Offset = "0x7546", VA = "0x7546")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F6")]
			[Address(RVA = "0x7547", Offset = "0x7547", VA = "0x7547")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C9")]
		public ulong CurrentBetId
		{
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x7548", Offset = "0x7548", VA = "0x7548")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60023F8")]
			[Address(RVA = "0x7549", Offset = "0x7549", VA = "0x7549")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CA")]
		public ResourceSet AcceptPrice
		{
			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x754A", Offset = "0x754A", VA = "0x754A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023FA")]
			[Address(RVA = "0x754B", Offset = "0x754B", VA = "0x754B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CB")]
		public ResourceSet UpdatePrice
		{
			[Token(Token = "0x60023FB")]
			[Address(RVA = "0x754C", Offset = "0x754C", VA = "0x754C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023FC")]
			[Address(RVA = "0x754D", Offset = "0x754D", VA = "0x754D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x754E", Offset = "0x754E", VA = "0x754E")]
		public void PopulateUsers()
		{
		/* --- GHIDRA: PopulateUsers ---
		int Gameplay_Portals_Model_PortalsTotalizatorModel__PopulateUsers
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined8 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a58139 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58139 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  piVar3 = *(int **)(param1 + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8))
		      {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ea78ab;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80ea78ab:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,uVar2,puVar1[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar5 = *(undefined8 *)(param2 + 0x18);
		  uVar6 = 0;
		  *(undefined1 *)(param1_00 + 0x40) = 0;
		  *(undefined4 *)(param1_00 + 0x28) = 1;
		  *(undefined8 *)(param1_00 + 0x20) = uVar5;
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param2 + 0x10);
		  piVar3 = *(int **)(param1 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea795b;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea795b:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  uVar2 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x3c),0);
		  *(undefined4 *)(param1_00 + 0x3c) = 0;
		  *(undefined4 *)(param1_00 + 0x34) = uVar2;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x754F", Offset = "0x754F", VA = "0x754F")]
		private UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs ConstructArgs(Bet bet)
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentBetList ---
		void Gameplay_Portals_Model_PortalsTotalizatorModel__set_CurrentBetList
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  Gameplay_Portals_Model_PortalsRatingModel__set_IsAwaitReceivingData
		            (param1,0.0,param2,param3,param4,param4);
		  return;
		}
		*/


		/* --- GHIDRA: set_UpdatePrice ---
		void Gameplay_Portals_Model_PortalsTotalizatorModel__set_UpdatePrice(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58138 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsTotalizatorModel_ConstructArgs__);
		    DAT_ram_00a58138 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x18);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Portals_Model_PortalsTotalizatorModel_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

}
