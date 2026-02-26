using System;
using AssetContent;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009EE RID: 2542
	[Token(Token = "0x20009EE")]
	public class ClanCurseView : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x06003CB3 RID: 15539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x448A", Offset = "0x448A", VA = "0x448A")]
		public void Init(ClanCurseData data)
		{
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x8B77", Offset = "0x8B77", VA = "0x8B77", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x8B78", Offset = "0x8B78", VA = "0x8B78")]
		public ClanCurseView()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Clans_Office_View_ClanCurseView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57eed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_ClanCursesIndicator_UpdateData__);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    DAT_ram_00a57eed = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x1c);
		  if (param1_01 == 0) {
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Gameplay_Clans_Office_View_ClanCursesIndicator_UpdateData__,0
		              );
		    param1_01 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,param1_00,0);
		    *(int *)(param1 + 0x1c) = param1_01;
		  }
		  return param1_01;
		}
		*/

		}

		// Token: 0x04002186 RID: 8582
		[Token(Token = "0x4002186")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanCurseToolTipView";

		// Token: 0x04002187 RID: 8583
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x04002188 RID: 8584
		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x14")]
		private ClanCurseData _data;
	}
}
