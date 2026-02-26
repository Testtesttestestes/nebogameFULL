using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Auchan.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	[RequireComponent(typeof(ArtifactView))]
	public class AuchanArtifactView : MonoBehaviour
	{
		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD3")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x6004E28")]
			[Address(RVA = "0x9C5B", Offset = "0x9C5B", VA = "0x9C5B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD4")]
		public Image Marker
		{
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x9C5C", Offset = "0x9C5C", VA = "0x9C5C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FD5")]
		public AuchanArtifactData ArtifactData
		{
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x9C5D", Offset = "0x9C5D", VA = "0x9C5D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E2B")]
			[Address(RVA = "0x9C5E", Offset = "0x9C5E", VA = "0x9C5E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0x9C5F", Offset = "0x9C5F", VA = "0x9C5F")]
		public void SetArtifactData(AuchanArtifactData data, UserData user, Sprite[] sprites)
		{
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x9C60", Offset = "0x9C60", VA = "0x9C60")]
		public AuchanArtifactView()
		{
		}

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _marker;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _marketAccountIcon;

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x1C")]
		private ArtifactView _artifactView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ArtifactData ---
		void Gameplay_Auchan_View_AuchanArtifactView__set_ArtifactData
		               (int param1,int param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a59846 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a59846 = '\x01';
		  }
		  *(int *)(param1 + 0x20) = param2;
		  if (DAT_ram_00a59845 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59845 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar5,0,0);
		  if (iVar2 == 0) {
		    piVar3 = *(int **)(param1 + 0x1c);
		  }
		  else {
		    piVar3 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_ArtifactView___);
		    *(int **)(param1 + 0x1c) = piVar3;
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		            (piVar3,*(undefined4 *)(param2 + 0x1c),*(undefined4 *)(*piVar3 + 0x13c));
		  uVar6 = *(undefined4 *)(param1 + 0x10);
		  uVar5 = func_ii_7954(*(undefined4 *)(param2 + 0x1c),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		  UI_Price_Price__SetColor(uVar6,param3,uVar5,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if (piVar3 != (int *)0x0) {
		    uVar1 = 0;
		    iVar2 = *piVar3;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x81079b4f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,4);
		code_r0x81079b4f:
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		    if (-1 < iVar2 + -1) {
		      func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param4 + (iVar2 + -1) * 4 + 0x10),
		                   0);
		      uVar5 = 1;
		      goto code_r0x81079b84;
		    }
		  }
		  uVar5 = 0;
		code_r0x81079b84:
		  uVar1 = 0;
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x14),uVar5,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a5986b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    DAT_ram_00a5986b = '\x01';
		  }
		  piVar3 = *(int **)(param2 + 0x20);
		  if (piVar3 == (int *)0x0) {
		    uVar6 = 0;
		  }
		  else {
		    iVar2 = *piVar3;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81079c32;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,0);
		code_r0x81079c32:
		    uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,uVar6,0);
		  return;
		}
		*/

}
