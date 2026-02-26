using System;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public abstract class AbstractActionOnEventView : MonoBehaviour
	{
		// Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x7E73", Offset = "0x7E73", VA = "0x7E73", Slot = "4")]
		public virtual void SetOnTriggeredCallback(EventHandler<AbstractActionOnEvent> callback)
		{
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D6")]
		public AbstractActionOnEvent Data
		{
			[Token(Token = "0x6002DF6")]
			[Address(RVA = "0x7E74", Offset = "0x7E74", VA = "0x7E74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF7")]
			[Address(RVA = "0x7E75", Offset = "0x7E75", VA = "0x7E75")]
			set
			{
			}
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x7E76", Offset = "0x7E76", VA = "0x7E76", Slot = "5")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x7E77", Offset = "0x7E77", VA = "0x7E77")]
		protected AbstractActionOnEventView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_View_ActionsOnEvens_AbstractActionOnEventView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton_HandleOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a574b1 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton_HandleOnClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _labelField;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x14")]
		private AbstractActionOnEvent _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GameEvents_View_ActionsOnEvens_AbstractActionOnEventView__get_Data
		               (int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[5]) {
		    param1[5] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GameEvents_View_ActionsOnEvens_AbstractActionOnEventView__set_Data
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),
		             *(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

}
