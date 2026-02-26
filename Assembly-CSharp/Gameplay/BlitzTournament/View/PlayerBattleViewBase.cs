using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x2000BCE")]
	public abstract class PlayerBattleViewBase : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140001CD RID: 461
		// (add) Token: 0x06004A0B RID: 18955 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004A0C RID: 18956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001CD")]
		public event Action<PlayerBattleViewBase> ClickedEvent
		{
			[Token(Token = "0x6004A0B")]
			[Address(RVA = "0x9875", Offset = "0x9875", VA = "0x9875")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004A0C")]
			[Address(RVA = "0x9876", Offset = "0x9876", VA = "0x9876")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06004A0D RID: 18957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EFA")]
		public GameObject SelectImage
		{
			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x9877", Offset = "0x9877", VA = "0x9877")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06004A0E RID: 18958
		[Token(Token = "0x17000EFB")]
		protected abstract uint _totalHealth { [Token(Token = "0x6004A0E")] get; }

		// Token: 0x06004A0F RID: 18959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A0F")]
		[Address(RVA = "0x9878", Offset = "0x9878", VA = "0x9878", Slot = "6")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_BlitzTournament_View_PlayerBattleViewBase__OnPointerClick
		               (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int *piVar2;
		  float fVar3;
		  
		  UnityEngine_Component__GetComponentInChildren_object_(param1[4],param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1[6],param3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  piVar2 = (int *)param1[5];
		  if (iVar1 == 0) {
		    fVar3 = 0.0;
		  }
		  else {
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xec));
		    fVar3 = Utils_MathUtils_MathUtils__SaferDivide((float)param4,param2_00,0);
		  }
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x108) * 4))
		            (piVar2,fVar3,*(undefined4 *)(iVar1 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A10")]
		[Address(RVA = "0x1D03", Offset = "0x1D03", VA = "0x1D03")]
		public void SetHealth(int value)
		{
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A11")]
		[Address(RVA = "0x9879", Offset = "0x9879", VA = "0x9879", Slot = "7")]
		protected virtual void Init(string nickName, string cultIconAssetId, uint currentHealth)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_BlitzTournament_View_PlayerBattleViewBase__Init(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x20) = 0x4342000042940000;
		  *(undefined8 *)(param1 + 0x28) = 0x3f800000436c0000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A12")]
		[Address(RVA = "0x987A", Offset = "0x987A", VA = "0x987A")]
		protected PlayerBattleViewBase()
		{
		}

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _nickname;

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ProgressBar _health;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected GameRawImage _cultIcon;

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected GameObject _selectImage;

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Color _playerColor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_BlitzTournament_View_PlayerBattleViewBase__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a608ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PlayerBattleViewBase__TypeInfo);
		    DAT_ram_00a608ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: get_SelectImage ---
		void Gameplay_BlitzTournament_View_PlayerBattleViewBase__get_SelectImage
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
