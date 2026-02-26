using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI.UserContextMenu.ContextElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.UserContextMenu
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public class UserContextMenuElement : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00003618 File Offset: 0x00001818
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public bool ButtonBehaviour
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x5CA3", Offset = "0x5CA3", VA = "0x5CA3")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x5CA4", Offset = "0x5CA4", VA = "0x5CA4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x06000928 RID: 2344 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D2")]
		public event Action<UserContextMenuElement> SelectEvent
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x5CA5", Offset = "0x5CA5", VA = "0x5CA5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x5CA6", Offset = "0x5CA6", VA = "0x5CA6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public AbstractUserContextMenuElement AbstractContextMenuElement
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x5CA7", Offset = "0x5CA7", VA = "0x5CA7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x5CA8", Offset = "0x5CA8", VA = "0x5CA8")]
			set
			{
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5CA9", Offset = "0x5CA9", VA = "0x5CA9", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		void UI_UserContextMenu_UserContextMenuElement__OnPointerDown
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(char *)(param1 + 0x28) != '\0') && (iVar1 = *(int *)(param1 + 0x2c), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x5CAA", Offset = "0x5CAA", VA = "0x5CAA", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x5CAB", Offset = "0x5CAB", VA = "0x5CAB")]
		public UserContextMenuElement()
		{
		}

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _iconLoader;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _labelGroup;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _enabledBgSprite;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _disabledBgSprite;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x30")]
		private AbstractUserContextMenuElement _abstractContextMenuElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ButtonBehaviour ---
		void UI_UserContextMenu_UserContextMenuElement__set_ButtonBehaviour
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		    DAT_ram_00a5b8c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserContextMenuElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserContextMenuElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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
		void UI_UserContextMenu_UserContextMenuElement__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserContextMenuElement__TypeInfo);
		    DAT_ram_00a5b8c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserContextMenuElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserContextMenuElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: get_AbstractContextMenuElement ---
		void UI_UserContextMenu_UserContextMenuElement__get_AbstractContextMenuElement
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5b8c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a5b8c3 = '\x01';
		  }
		  *(int *)(param1 + 0x30) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  if (param2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x30) + 8),
		               *(undefined4 *)(iVar1 + 0x2d4));
		    func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x20),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x30) + 0x10),
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_AbstractContextMenuElement ---
		void UI_UserContextMenu_UserContextMenuElement__set_AbstractContextMenuElement
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(char *)(param1 + 0x28) == '\0') && (iVar1 = *(int *)(param1 + 0x2c), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
