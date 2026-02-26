using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FD RID: 1533
	[Token(Token = "0x20005FD")]
	public class FilterButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x1400014F RID: 335
		// (add) Token: 0x06002536 RID: 9526 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014F")]
		public event Action<FilterButton> ClickEvent
		{
			[Token(Token = "0x6002536")]
			[Address(RVA = "0x767F", Offset = "0x767F", VA = "0x767F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x7680", Offset = "0x7680", VA = "0x7680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x7681", Offset = "0x7681", VA = "0x7681")]
		private void Awake()
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x7682", Offset = "0x7682", VA = "0x7682")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x7683", Offset = "0x7683", VA = "0x7683")]
		private void ClickedHandler()
		{
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00007128 File Offset: 0x00005328
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FC")]
		public bool Selected
		{
			[Token(Token = "0x600253B")]
			[Address(RVA = "0x7684", Offset = "0x7684", VA = "0x7684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600253C")]
			[Address(RVA = "0x7685", Offset = "0x7685", VA = "0x7685")]
			set
			{
			}
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x7686", Offset = "0x7686", VA = "0x7686", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Medals_View_FilterButton__OnPointerClick
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a57d9d = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x3f8ccccd3f8ccccd;
		  local_18 = 0x3f8ccccd3f8ccccd;
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_18,0.15,0);
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x7687", Offset = "0x7687", VA = "0x7687", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Gameplay_Medals_View_FilterButton__OnPointerEnter
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a57d9e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a57d9e = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_10,0.4,0);
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x7688", Offset = "0x7688", VA = "0x7688", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x7689", Offset = "0x7689", VA = "0x7689")]
		public FilterButton()
		{
		}

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _defaultImagePath;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private string _selectedImagePath;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _imageOn;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _imageOff;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x24")]
		private bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Medals_View_FilterButton__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d9b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterButton__TypeInfo);
		    DAT_ram_00a57d9b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_FilterButton__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_FilterButton__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Medals_View_FilterButton__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57d9c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d9c = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e5aa46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e5aa46:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,*(undefined4 *)(param1 + 0x10),0);
		  AssetContent_GameImage__get_AssetId(uVar4,uVar3,0);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e5ab10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e5ab10:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,*(undefined4 *)(param1 + 0x14),0);
		  AssetContent_GameImage__get_AssetId(uVar4,uVar3,0);
		  *(undefined1 *)(param1 + 0x24) = 0;
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(*(char *)(param1 + 0x24) == '\0'),0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)*(byte *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void Gameplay_Medals_View_FilterButton__get_Selected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  *(undefined1 *)(param1 + 0x24) = (undefined1)param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x24) == '\0'),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_Medals_View_FilterButton__set_Selected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
