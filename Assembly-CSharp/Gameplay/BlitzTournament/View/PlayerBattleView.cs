using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using UI.ToolTip;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	public class PlayerBattleView : PlayerBattleViewBase, IToolTipDataProvider
	{
		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A04 RID: 18948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EF7")]
		public FighterInfo Fighter
		{
			[Token(Token = "0x6004A03")]
			[Address(RVA = "0x986D", Offset = "0x986D", VA = "0x986D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A04")]
			[Address(RVA = "0x986E", Offset = "0x986E", VA = "0x986E")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06004A05 RID: 18949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A06 RID: 18950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EF8")]
		public UserData UserData
		{
			[Token(Token = "0x6004A05")]
			[Address(RVA = "0x986F", Offset = "0x986F", VA = "0x986F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A06")]
			[Address(RVA = "0x9870", Offset = "0x9870", VA = "0x9870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x17000EF9")]
		protected override uint _totalHealth
		{
			[Token(Token = "0x6004A07")]
			[Address(RVA = "0x9871", Offset = "0x9871", VA = "0x9871", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x9872", Offset = "0x9872", VA = "0x9872")]
		public void Init(FighterInfo fighter)
		{
		/* --- GHIDRA: Init ---
		int Gameplay_BlitzTournament_View_PlayerBattleView__Init(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a608ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_UserData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12544);
		    DAT_ram_00a608ab = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_UserData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12544,Method_UI_ToolTip_ToolTipData_UserData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x38);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x9873", Offset = "0x9873", VA = "0x9873", Slot = "8")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x9874", Offset = "0x9874", VA = "0x9874")]
		public PlayerBattleView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_View_PlayerBattleView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a608ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PlayerBattleViewBase__TypeInfo);
		    DAT_ram_00a608ac = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_PlayerBattleViewBase__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PlayerBattleViewBase__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_UserData ---
		undefined4
		Gameplay_BlitzTournament_View_PlayerBattleView__set_UserData(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x34) + 0x1c);
		}
		*/


		/* --- GHIDRA: get__totalHealth ---
		void Gameplay_BlitzTournament_View_PlayerBattleView__get__totalHealth
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a608aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a608aa = '\x01';
		  }
		  param1[0xd] = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x81cf2464;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf2464:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x81cf2516;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x81cf2516:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  uVar6 = *(undefined4 *)(param2 + 0xc);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cf25a2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x81cf25a2:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar6,puVar2[1]);
		  param1[0xe] = iVar5;
		  uVar6 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0x18);
		  uVar3 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                    (uVar3,*(undefined4 *)(*(int *)(param2 + 0xc) + 0x24),0);
		  uVar3 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,uVar6,uVar3,*(undefined4 *)(param2 + 0x18),*(undefined4 *)(*param1 + 0xfc));
		  return;
		}
		*/

}
