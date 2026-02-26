using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public class SkillRow : TitleIconValueBackground, IToolTipDataProvider, IDisposable
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x69AE", Offset = "0x69AE", VA = "0x69AE")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042B")]
		public UserData User
		{
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x69AF", Offset = "0x69AF", VA = "0x69AF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017F5")]
			[Address(RVA = "0x69B0", Offset = "0x69B0", VA = "0x69B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x69B1", Offset = "0x69B1", VA = "0x69B1")]
		public void Init(UserData user, UserSkillDic userSkillDic, SkillData skillData)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_UserInfo_View_SkillRow__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(undefined4 *)(param1 + 0x38) = param2;
		  uVar1 = func_ii_7990(param2,0);
		  if (DAT_ram_00a598e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a598e9 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_2003,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar1 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x24),uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x69B2", Offset = "0x69B2", VA = "0x69B2")]
		public void SetUserSkillDic(UserSkillDic value)
		{
		/* --- GHIDRA: SetUserSkillDic ---
		int Gameplay_UserInfo_View_SkillRow__SetUserSkillDic(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a598e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_SkillToolTipInUserInfoVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_SkillToolTipInUserInfoVO___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_SkillToolTipInUserInfoVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_SkillToolTipInUserInfoVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12540);
		    DAT_ram_00a598e7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_SkillToolTipInUserInfoVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12540,
		             Method_UI_ToolTip_ToolTipData_SkillToolTipInUserInfoVO___ctor__);
		  iVar1 = unnamed_function_1417(UI_ToolTip_Implementations_VO_SkillToolTipInUserInfoVO_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param1 + 0x38);
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param1 + 0x40);
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param1 + 0x3c);
		  *(int *)(param1_00 + 0x1c) = iVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017F8")]
		[Address(RVA = "0x69B3", Offset = "0x69B3", VA = "0x69B3", Slot = "6")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_UserInfo_View_SkillRow__GetData(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x40) = 0;
		  *(undefined4 *)(param1 + 0x38) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x69B4", Offset = "0x69B4", VA = "0x69B4", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0x69B5", Offset = "0x69B5", VA = "0x69B5")]
		public SkillRow()
		{
		}

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x38")]
		private UserSkillDic _skillDic;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x3C")]
		private SkillData _skillData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_User ---
		void Gameplay_UserInfo_View_SkillRow__set_User
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(undefined4 *)(param1 + 0x40) = param2;
		  *(undefined4 *)(param1 + 0x3c) = param4;
		  *(undefined4 *)(param1 + 0x38) = param3;
		  uVar1 = func_ii_7990(param3,0);
		  if (DAT_ram_00a598e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a598e9 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_2003,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar1 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(param3,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x24),uVar1,0);
		  return;
		}
		*/

}
