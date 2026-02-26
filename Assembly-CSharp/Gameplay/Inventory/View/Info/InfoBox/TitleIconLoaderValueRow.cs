using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class TitleIconLoaderValueRow : TitleRowView
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079B")]
		public string Value
		{
			[Token(Token = "0x600282D")]
			[Address(RVA = "0x7952", Offset = "0x7952", VA = "0x7952")]
			get
			{
				return null;
			}
			[Token(Token = "0x600282E")]
			[Address(RVA = "0x1F80", Offset = "0x1F80", VA = "0x1F80")]
			set
			{
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x1F7F", Offset = "0x1F7F", VA = "0x1F7F")]
		public void SetIcon(string assetId)
		{
		/* --- GHIDRA: SetIcon ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__SetIcon
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x28),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x1F7E", Offset = "0x1F7E", VA = "0x1F7E")]
		public void SetValueColor(in Color32 color)
		{
		}

		// Token: 0x1700079C RID: 1948
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079C")]
		public override TextAnchor ContainerAlign
		{
			[Token(Token = "0x6002831")]
			[Address(RVA = "0x7953", Offset = "0x7953", VA = "0x7953", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x7954", Offset = "0x7954", VA = "0x7954")]
		public TitleIconLoaderValueRow()
		{
		}

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _loader;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TextMeshProUGUI _valueField;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayoutGroup _layoutGroup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__get_Value
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_UI_LayoutGroup__get_childAlignment(*(undefined4 *)(param1 + 0x2c),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  System_Collections_Generic_KeyValuePair_int__long____ctor
		            (param1,param2,param3,1,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x88)
		            );
		  return;
		}
		*/

}
