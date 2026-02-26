using System;
using AssetContent;
using Gameplay.ThemeDuelState.Control;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.ThemeDuelState.View.Lobby
{
	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	public class ThemeDuelLobbyView : MonoBehaviour
	{
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000539")]
		public IndexButtonBasic ThemeDuelButton
		{
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x6EB9", Offset = "0x6EB9", VA = "0x6EB9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053A")]
		public TextMeshProUGUI ThemeDuelScore
		{
			[Token(Token = "0x6001D3B")]
			[Address(RVA = "0x6EBA", Offset = "0x6EBA", VA = "0x6EBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x6EBB", Offset = "0x6EBB", VA = "0x6EBB")]
		private void Awake()
		{
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x6EBC", Offset = "0x6EBC", VA = "0x6EBC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x6EBD", Offset = "0x6EBD", VA = "0x6EBD")]
		public void UpdateView(string iconAssetId)
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_ThemeDuelState_View_Lobby_ThemeDuelLobbyView__UpdateView(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5857f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_TypeInfo);
		    DAT_ram_00a5857f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x288);
		        goto code_r0x80f0795e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f0795e:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(iVar4 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x288);
		        goto code_r0x80f07a10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f07a10:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(iVar4 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x288);
		        goto code_r0x80f07ac2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f07ac2:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x10);
		  *(undefined4 *)(param1 + 0x28) = param4;
		  param2_00 = *(undefined4 *)(param1 + 0x24);
		  param3 = *(undefined4 *)(param1 + 0x20);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_TypeInfo);
		  if (DAT_ram_00a58591 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelStateModel__ThemeDuelStateEvents__ThemeDuelStateController__ThemeDuelLobbyView___ctor__
		              );
		    DAT_ram_00a58591 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_ThemeDuelStateModel__ThemeDuelStateEvents__ThemeDuelStateController__ThemeDuelLobbyView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x1c) = piVar3;
		  return;
		}
		*/

		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x6EBE", Offset = "0x6EBE", VA = "0x6EBE")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_ThemeDuelState_View_Lobby_ThemeDuelLobbyView__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x6EBF", Offset = "0x6EBF", VA = "0x6EBF")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x6EC0", Offset = "0x6EC0", VA = "0x6EC0")]
		public ThemeDuelLobbyView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_ThemeDuelState_View_Lobby_ThemeDuelLobbyView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58580 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		    DAT_ram_00a58580 = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    return *(undefined4 *)(param1 + 0x1c);
		  }
		  uVar1 = func_ii_6601(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_GameObject_GetComponent_CanvasGroup___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return uVar1;
		}
		*/

		}

		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IndexButtonBasic _themeDuelButton;

		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _themeDuelScore;

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x1C")]
		private ThemeDuelLobbyMediator _mediator;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x20")]
		private ThemeDuelStateEvents _events;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x24")]
		private ThemeDuelStateModel _model;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x28")]
		private ThemeDuelStateController _controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ThemeDuelScore ---
		void Gameplay_ThemeDuelState_View_Lobby_ThemeDuelLobbyView__get_ThemeDuelScore
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_ThemeDuelState_View_Lobby_ThemeDuelLobbyView__UpdateView(param1,param1);
		  return;
		}
		*/

}
