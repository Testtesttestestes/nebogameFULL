using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Craft;
using Protocol.Dic;
using Utils;

namespace Gameplay.User.Model
{
	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	public class UserModel : AbstractModel
	{
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x1700045E")]
		public int PremiumExpMinLevel
		{
			[Token(Token = "0x60018EC")]
			[Address(RVA = "0x6A8B", Offset = "0x6A8B", VA = "0x6A8B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700045F")]
		public ResourceSet TreeLicencePrice
		{
			[Token(Token = "0x60018ED")]
			[Address(RVA = "0x6A8C", Offset = "0x6A8C", VA = "0x6A8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000057C0 File Offset: 0x000039C0
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		public ulong RequestedClanId
		{
			[Token(Token = "0x60018EE")]
			[Address(RVA = "0x6A8D", Offset = "0x6A8D", VA = "0x6A8D")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60018EF")]
			[Address(RVA = "0x6A8E", Offset = "0x6A8E", VA = "0x6A8E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000461")]
		public Cults[] AvailableCults
		{
			[Token(Token = "0x60018F0")]
			[Address(RVA = "0x6A8F", Offset = "0x6A8F", VA = "0x6A8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x17000462")]
		public float ExperienceProgress
		{
			[Token(Token = "0x60018F1")]
			[Address(RVA = "0x6A90", Offset = "0x6A90", VA = "0x6A90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000463")]
		public UserLevelDic NextUserLevelDic
		{
			[Token(Token = "0x60018F2")]
			[Address(RVA = "0x6A91", Offset = "0x6A91", VA = "0x6A91")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000464")]
		public EnergyRegenStatus CurrentEnergyRegenStatus
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x6A92", Offset = "0x6A92", VA = "0x6A92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F4")]
			[Address(RVA = "0x6A93", Offset = "0x6A93", VA = "0x6A93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public UserProfession Profession
		{
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x6A94", Offset = "0x6A94", VA = "0x6A94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x6A95", Offset = "0x6A95", VA = "0x6A95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public BanInfo BanInfo
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x6A96", Offset = "0x6A96", VA = "0x6A96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x6A97", Offset = "0x6A97", VA = "0x6A97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x17000467")]
		public double EnergyRecoveryStep
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x6A98", Offset = "0x6A98", VA = "0x6A98")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000468")]
		public IGame Game
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x6A99", Offset = "0x6A99", VA = "0x6A99")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x6A9A", Offset = "0x6A9A", VA = "0x6A9A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x6A9B", Offset = "0x6A9B", VA = "0x6A9B", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_User_Model_UserModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               double param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  undefined4 param5_00;
		  double param4_00;
		  
		  if (DAT_ram_00a59952 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		    DAT_ram_00a59952 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param7,0);
		  *(undefined4 *)(param1 + 0x3c) = param4;
		  *(undefined4 *)(param1 + 0x38) = param3;
		  *(undefined4 *)(param1 + 0x40) = param2;
		  *(double *)(param1 + 0x30) = param6;
		  *(undefined4 *)(param1 + 0x28) = param5;
		  param2_00 = Utils_MoneyUtils__Create(0.0,0.0,0.0,NAN,NAN,0);
		  param3_00 = unnamed_function_1417(Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		  param5_00 = *(undefined4 *)(param1 + 0x28);
		  param4_00 = *(double *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		  Gameplay_User_Model_EnergyRegenStatus__set_FullEnergyRecoveryBacktime
		            (param1_00,param2_00,param3_00,param4_00,param5_00,param1);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x6A9C", Offset = "0x6A9C", VA = "0x6A9C")]
		public UserModel(IGame game, IUserCache userCache, LocalProps localProps, uint energyRecoveryIncrementInterval, double energyRecoveryIncrementPercentPerInterval, UserData user)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x6A9D", Offset = "0x6A9D", VA = "0x6A9D")]
		public void SetUserProfession(UserProfession profession)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x6A9E", Offset = "0x6A9E", VA = "0x6A9E")]
		public void SetBanInfo(BanInfo banInfo)
		{
		}

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x18")]
		private UserLevelDic _nextUserLevelDic;

		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x28")]
		public readonly uint EnergyRecoveryIncrementInterval;

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x30")]
		public readonly double EnergyRecoveryIncrementPercentPerInterval;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x38")]
		public readonly IUserCache UserCache;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x3C")]
		public readonly LocalProps LocalProps;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PremiumExpMinLevel ---
		undefined4 Gameplay_User_Model_UserModel__get_PremiumExpMinLevel(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double param3;
		  int *param1_00;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5994f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27860);
		    DAT_ram_00a5994f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x8109603c;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8109603c:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  param3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_27860,0);
		  uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  Core_Extensions_Dict_ResourceSetExt__HasNewCurrency(uVar2,2,param3,0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_RequestedClanId ---
		int Gameplay_User_Model_UserModel__set_RequestedClanId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param2_00;
		  uint uVar6;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a59950 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Cults___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Cults_var);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Cults__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Cults__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Cults___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Cults__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__8CA6EE1043DEFCFD05AA29DEE581CBC519E783E414A687D7C26AC6070D3F6DEE
		              );
		    DAT_ram_00a59950 = '\x01';
		  }
		  uVar4 = Protocol_Consts_Cults_var;
		  iVar5 = *(int *)(*(int *)(param1 + 8) + 0x68);
		  if (iVar5 == 0) {
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar4 = func_ii_2734(uVar4,0);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar5 = System_Enum__GetUnderlyingType(uVar4,0);
		    uVar4 = Protocol_Consts_Cults___TypeInfo;
		    if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,Protocol_Consts_Cults___TypeInfo), iVar3 == 0))
		    {
		      System_Activator__CreateInstance(iVar5,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_Cults__TypeInfo);
		    Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		              (param1_00,*(undefined4 *)(iVar3 + 0xc),
		               Method_System_Collections_Generic_List_Cults___ctor__);
		    iVar5 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar5) {
		      iVar2 = 0;
		      do {
		        iVar1 = Method_System_Collections_Generic_List_Cults__Add__;
		        param2_00 = *(int *)(iVar3 + iVar2 * 4 + 0x10);
		        if (param2_00 != 0) {
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar6 = *(uint *)(param1_00 + 0xc);
		          if (uVar6 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar6 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar6 * 4 + 0x10) = param2_00;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,param2_00,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		            iVar5 = *(int *)(iVar3 + 0xc);
		          }
		        }
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < iVar5);
		    }
		    uVar4 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (param1_00,Method_System_Collections_Generic_List_Cults__ToArray__);
		    return uVar4;
		  }
		  iVar3 = Gameplay_World_Model_ClanData__get_IsFraction(iVar5,0);
		  if (iVar3 != 0) {
		    uVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_Cults___TypeInfo,3);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (uVar4,
		               Field__PrivateImplementationDetails__8CA6EE1043DEFCFD05AA29DEE581CBC519E783E414A687D7C26AC6070D3F6DEE
		               ,0);
		    return uVar4;
		  }
		  iVar3 = Gameplay_World_Model_ClanData__get_IsLeftHandClan
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x68),0);
		  if (iVar3 != 0) {
		    uVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_Cults___TypeInfo,3);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (uVar4,
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		               ,0);
		    return uVar4;
		  }
		  iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_Cults___TypeInfo,1);
		  *(undefined4 *)(iVar3 + 0x10) =
		       *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x68) + 0x1c) + 0x1c);
		  return iVar3;
		}
		*/


		/* --- GHIDRA: get_AvailableCults ---
		float Gameplay_User_Model_UserModel__get_AvailableCults(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  ulonglong uVar3;
		  
		  iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1,param1);
		  if (iVar1 != 0) {
		    uVar3 = *(ulonglong *)(*(int *)(param1 + 8) + 0x58);
		    iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1,param1);
		    fVar2 = UnityEngine_Camera__set_orthographicSize
		                      ((float)uVar3,(float)*(ulonglong *)(iVar1 + 0x10),0);
		    return fVar2;
		  }
		  return 1.0;
		}
		*/


		/* --- GHIDRA: get_ExperienceProgress ---
		undefined4 Gameplay_User_Model_UserModel__get_ExperienceProgress(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59951 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59951 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x18) != 0) &&
		     (iVar4 = *(int *)(*(int *)(param1 + 0x18) + 0xc),
		     iVar5 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 8),0), iVar4 == iVar5 + 1)) {
		    return *(undefined4 *)(param1 + 0x18);
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8108c501;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108c501:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar5 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 8),0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar3,iVar5 + 1,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_BanInfo ---
		double Gameplay_User_Model_UserModel__set_BanInfo(int param1,undefined4 param2)
		
		{
		  return *(double *)(param1 + 0x30) *
		         (double)*(uint *)(*(int *)(*(int *)(param1 + 0x1c) + 8) + 0x10);
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Gameplay_User_Model_UserModel__set_Game(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  *(undefined8 *)(iVar1 + 8) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
