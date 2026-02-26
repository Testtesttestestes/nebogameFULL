using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Tabs
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public class CategoryTabBarItemView : MonoBehaviour, ITabBarItemView, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x5DD5", Offset = "0x5DD5", VA = "0x5DD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DA")]
		public event Action<TabBarItemData> SelectEvent
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x5DD6", Offset = "0x5DD6", VA = "0x5DD6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x5DD7", Offset = "0x5DD7", VA = "0x5DD7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public TabBarItemData Data
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x5DD8", Offset = "0x5DD8", VA = "0x5DD8", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x5DD9", Offset = "0x5DD9", VA = "0x5DD9", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x5DDA", Offset = "0x5DDA", VA = "0x5DDA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public bool Selected
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x5DDB", Offset = "0x5DDB", VA = "0x5DDB", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x5DDC", Offset = "0x5DDC", VA = "0x5DDC", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x5DDD", Offset = "0x5DDD", VA = "0x5DDD", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x5DDE", Offset = "0x5DDE", VA = "0x5DDE")]
		public CategoryTabBarItemView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Tabs_CategoryTabBarItemView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a599c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a599c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _label;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Image _image;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _fontColorSelected;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _fontColorDefault;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _spriteDefault;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Sprite _spriteSelected;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x40")]
		private IGuideTarget _guideTarget;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x48")]
		private TabBarItemData _data;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x4C")]
		private bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideTarget ---
		void UI_Tabs_CategoryTabBarItemView__get_GuideTarget(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    DAT_ram_00a599c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TabBarItemData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TabBarItemData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectEvent ---
		void UI_Tabs_CategoryTabBarItemView__add_SelectEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    DAT_ram_00a599c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TabBarItemData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TabBarItemData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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
		void UI_Tabs_CategoryTabBarItemView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a599c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a599c8 = '\x01';
		  }
		  *(int *)(param1 + 0x48) = param2;
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar2 = System_Uri__get_Authority(*(undefined4 *)(param2 + 0x10),0);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  if (DAT_ram_00a599c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a599c5 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x40);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int **)(param1 + 0x40) = piVar4;
		  }
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x810a05e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		code_r0x810a05e8:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (DAT_ram_00a599c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a599c5 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x40);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    *(int **)(param1 + 0x40) = piVar4;
		  }
		  uVar1 = 0;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		  *(ulonglong *)(iVar5 + 0x10) = (ulonglong)*(uint *)(*(int *)(param1 + 0x48) + 0x14);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x810a06c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5);
		code_r0x810a06c2:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,iVar5,puVar3[1]);
		  UnityEngine_Object__op_Implicit(uVar2,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void UI_Tabs_CategoryTabBarItemView__get_Selected(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(char *)(param1 + 0x4c) = (char)param2;
		  iVar1 = 0x3c;
		  if (param2 == 0) {
		    iVar1 = 0x38;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + iVar1),0);
		  iVar1 = 0x18;
		  if (*(char *)(param1 + 0x4c) == '\0') {
		    iVar1 = 0x28;
		  }
		  local_18 = ((undefined8 *)(param1 + iVar1))[1];
		  local_20 = *(undefined8 *)(param1 + iVar1);
		  iVar1 = **(int **)(param1 + 0x10);
		  local_10 = local_20;
		  local_8 = local_18;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x10),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_Tabs_CategoryTabBarItemView__set_Selected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x48),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
