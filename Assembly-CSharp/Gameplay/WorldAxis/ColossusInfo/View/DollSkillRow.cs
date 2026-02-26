using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	public class DollSkillRow : TitleIconValueBackground, IToolTipDataProvider
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x6478", Offset = "0x6478", VA = "0x6478")]
		public void Init(DollSkillDic dic)
		{
		/* --- GHIDRA: Init ---
		int Gameplay_WorldAxis_ColossusInfo_View_DollSkillRow__Init(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58bd1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    DAT_ram_00a58bd1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  uVar1 = MVC_AbstractModel__set_User(*(undefined4 *)(param1 + 0x38),0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

		/* --- GHIDRA: Init ---
		int Gameplay_WorldAxis_ColossusInfo_View_DollSkillRow__Init(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58bd1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    DAT_ram_00a58bd1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  uVar1 = MVC_AbstractModel__set_User(*(undefined4 *)(param1 + 0x38),0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x6479", Offset = "0x6479", VA = "0x6479")]
		public void Init(DollSkillDic dic, StoneDic stoneDic)
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x647A", Offset = "0x647A", VA = "0x647A", Slot = "6")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x647B", Offset = "0x647B", VA = "0x647B")]
		public DollSkillRow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_View_DollSkillRow___ctor
		               (int *param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  param1[9] = param4;
		  param1[8] = param2;
		  param1[7] = param3;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x38")]
		private DollSkillDic _dic;
	}
}
