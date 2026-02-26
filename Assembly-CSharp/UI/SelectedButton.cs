using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UI
{
	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	public class SelectedButton : MonoBehaviourWithStates<SelectedButton.SelectedButtonStates>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140000CC RID: 204
		// (add) Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CC")]
		public event EventHandler<PointerEventData> ClickEvent
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x5C38", Offset = "0x5C38", VA = "0x5C38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x5C39", Offset = "0x5C39", VA = "0x5C39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		public bool Selected
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x5C3A", Offset = "0x5C3A", VA = "0x5C3A")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x5C3B", Offset = "0x5C3B", VA = "0x5C3B")]
			set
			{
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x5C3C", Offset = "0x5C3C", VA = "0x5C3C")]
		private void HandleSelectedChanged()
		{
		/* --- GHIDRA: HandleSelectedChanged ---
		void UI_SelectedButton__HandleSelectedChanged(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint param2_00;
		  
		  param2_00 = *(byte *)(param1 + 0x20) ^ 1;
		  *(char *)(param1 + 0x20) = (char)param2_00;
		  if (DAT_ram_00a5b89a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		              );
		    DAT_ram_00a5b89a = '\x01';
		    param2_00 = (uint)*(byte *)(param1 + 0x20);
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,param2_00,
		             Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		            );
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x5C3D", Offset = "0x5C3D", VA = "0x5C3D", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_SelectedButton__OnPointerClick(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b89b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates___ctor__);
		    DAT_ram_00a5b89b = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x5C3E", Offset = "0x5C3E", VA = "0x5C3E")]
		public SelectedButton()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_SelectedButton___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = AssetContent_GameImage___ctor(*(undefined4 *)(param1 + 0x10),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x20")]
		private bool _selected;

		// Token: 0x02000112 RID: 274
		[Token(Token = "0x2000112")]
		public enum SelectedButtonStates
		{
			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			DEFAULT,
			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			SELECTED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void UI_SelectedButton__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b899 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_PointerEventData__TypeInfo);
		    DAT_ram_00a5b899 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_PointerEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_PointerEventData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: get_Selected ---
		void UI_SelectedButton__get_Selected(int param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 0x20)) {
		    *(char *)(param1 + 0x20) = (char)param2;
		    if (DAT_ram_00a5b89a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		                );
		      DAT_ram_00a5b89a = '\x01';
		      param2 = (uint)*(byte *)(param1 + 0x20);
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,param2 & 0xff,
		               Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		              );
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_SelectedButton__set_Selected(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b89a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		              );
		    DAT_ram_00a5b89a = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,(uint)*(byte *)(param1 + 0x20),
		             Method_UI_MonoBehaviourWithStates_SelectedButton_SelectedButtonStates__set_CurrentState__
		            );
		  return;
		}
		*/

}
