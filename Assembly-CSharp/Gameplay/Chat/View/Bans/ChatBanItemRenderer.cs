using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	public class ChatBanItemRenderer : MonoBehaviourWithStates<ChatBanItemRenderer.ChatBanItemRendererStates>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140001AD RID: 429
		// (add) Token: 0x060043FA RID: 17402 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043FB RID: 17403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AD")]
		public event EventHandler<ChatBanArticleData> ClickEvent
		{
			[Token(Token = "0x60043FA")]
			[Address(RVA = "0x92AD", Offset = "0x92AD", VA = "0x92AD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x92AE", Offset = "0x92AE", VA = "0x92AE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043FD RID: 17405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D62")]
		public ChatBanArticleData Data
		{
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x92AF", Offset = "0x92AF", VA = "0x92AF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043FD")]
			[Address(RVA = "0x92B0", Offset = "0x92B0", VA = "0x92B0")]
			set
			{
			}
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x92B1", Offset = "0x92B1", VA = "0x92B1")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer__HandleDataChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(param1 + 0x24),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x92B2", Offset = "0x92B2", VA = "0x92B2", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer__OnPointerClick(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57b26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		              );
		    DAT_ram_00a57b26 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x1c);
		  uVar1 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle
		                    (*(undefined4 *)(*(int *)(param1 + 0x24) + 8),0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar1 = 2;
		  if (*(char *)(*(int *)(param1 + 0x24) + 0xc) == '\0') {
		    uVar1 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar1,
		             Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004400")]
		[Address(RVA = "0x92B3", Offset = "0x92B3", VA = "0x92B3")]
		public void DataUpdated()
		{
		/* --- GHIDRA: DataUpdated ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer__DataUpdated(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57b27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates___ctor__
		              );
		    DAT_ram_00a57b27 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004401")]
		[Address(RVA = "0x92B4", Offset = "0x92B4", VA = "0x92B4")]
		public ChatBanItemRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b28 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0xa0,iVar2,param1_00);
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

		// Token: 0x04002572 RID: 9586
		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _titleTextFaild;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x24")]
		private ChatBanArticleData _data;

		// Token: 0x02000B00 RID: 2816
		[Token(Token = "0x2000B00")]
		public enum ChatBanItemRendererStates
		{
			// Token: 0x04002576 RID: 9590
			[Token(Token = "0x4002576")]
			UNKNOWN,
			// Token: 0x04002577 RID: 9591
			[Token(Token = "0x4002577")]
			DEFAULT,
			// Token: 0x04002578 RID: 9592
			[Token(Token = "0x4002578")]
			SELECTED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b25 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_Data ---
		void Gameplay_Chat_View_Bans_ChatBanItemRenderer__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (param2 != *(int *)(param1 + 0x24)) {
		    *(int *)(param1 + 0x24) = param2;
		    if (DAT_ram_00a57b26 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		                );
		      DAT_ram_00a57b26 = '\x01';
		      param2 = *(int *)(param1 + 0x24);
		    }
		    piVar2 = *(int **)(param1 + 0x1c);
		    uVar1 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle(*(undefined4 *)(param2 + 8),0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    uVar1 = 2;
		    if (*(char *)(*(int *)(param1 + 0x24) + 0xc) == '\0') {
		      uVar1 = 1;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,uVar1,
		               Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		              );
		  }
		  return;
		}
		*/

}
