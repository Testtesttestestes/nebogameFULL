using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class VisitorItemRenderer : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140001A5 RID: 421
		// (add) Token: 0x0600438D RID: 17293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600438E RID: 17294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A5")]
		public event EventHandler<ChatVisitorData> ClickEvent
		{
			[Token(Token = "0x600438D")]
			[Address(RVA = "0x9241", Offset = "0x9241", VA = "0x9241")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600438E")]
			[Address(RVA = "0x9242", Offset = "0x9242", VA = "0x9242")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x9243", Offset = "0x9243", VA = "0x9243")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Chat_View_VisitorItemRenderer__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57af1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_VisitorItemRenderer_AttackButtonClickedEventHandler__);
		    DAT_ram_00a57af1 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Chat_View_VisitorItemRenderer_AttackButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x9244", Offset = "0x9244", VA = "0x9244")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		// (set) Token: 0x06004392 RID: 17298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D51")]
		public int Index
		{
			[Token(Token = "0x6004391")]
			[Address(RVA = "0x9245", Offset = "0x9245", VA = "0x9245")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004392")]
			[Address(RVA = "0x9246", Offset = "0x9246", VA = "0x9246")]
			set
			{
			}
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004393")]
		[Address(RVA = "0x9247", Offset = "0x9247", VA = "0x9247")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_Chat_View_VisitorItemRenderer__AttackButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x24;
		  if ((*(uint *)(param1 + 0x38) & 1) == 0) {
		    iVar1 = 0x28;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1 + iVar1),0);
		  return;
		}
		*/

		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004394")]
		[Address(RVA = "0x9248", Offset = "0x9248", VA = "0x9248")]
		private void HandleIndexChanged()
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D52")]
		public ChatVisitorData Data
		{
			[Token(Token = "0x6004395")]
			[Address(RVA = "0x9249", Offset = "0x9249", VA = "0x9249")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004396")]
			[Address(RVA = "0x924A", Offset = "0x924A", VA = "0x924A")]
			set
			{
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D53")]
		public string Title
		{
			[Token(Token = "0x6004397")]
			[Address(RVA = "0x924B", Offset = "0x924B", VA = "0x924B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004398")]
			[Address(RVA = "0x924C", Offset = "0x924C", VA = "0x924C")]
			set
			{
			}
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x924D", Offset = "0x924D", VA = "0x924D")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Chat_View_VisitorItemRenderer__HandleDataChanged(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Chat_View_VisitorItemRenderer__set_Title(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x924E", Offset = "0x924E", VA = "0x924E")]
		public void DataUpdated()
		{
		/* --- GHIDRA: DataUpdated ---
		void Gameplay_Chat_View_VisitorItemRenderer__DataUpdated
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(param1 + 0x40),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x924F", Offset = "0x924F", VA = "0x924F", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Chat_View_VisitorItemRenderer__OnPointerClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57af4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2354);
		    DAT_ram_00a57af4 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                    (StringLiteral_2354,*(undefined4 *)(param1 + 0x44),0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x9250", Offset = "0x9250", VA = "0x9250", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Gameplay_Chat_View_VisitorItemRenderer__OnPointerEnter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x9251", Offset = "0x9251", VA = "0x9251", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		void Gameplay_Chat_View_VisitorItemRenderer__OnPointerExit(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x38) = 0xffffffff;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x9252", Offset = "0x9252", VA = "0x9252")]
		public VisitorItemRenderer()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Chat_View_VisitorItemRenderer___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x20);
		  uVar1 = System_UInt32__CompareTo
		                    (&local_4,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x20),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _miscIcon;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _cultIcon;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _titleField;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _levelField;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _background;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _notEvenBackgroundSprite;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _evenBackgroundSprite;

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _moderatorIconSprite;

		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _visitorBannedIconSprite;

		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		[FieldOffset(Offset = "0x38")]
		private int _index;

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x40")]
		private ChatVisitorData _data;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0x44")]
		private string _title;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Chat_View_VisitorItemRenderer__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57aef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatVisitorData__TypeInfo);
		    DAT_ram_00a57aef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatVisitorData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatVisitorData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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
		void Gameplay_Chat_View_VisitorItemRenderer__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57af0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_VisitorItemRenderer_AttackButtonClickedEventHandler__);
		    DAT_ram_00a57af0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Chat_View_VisitorItemRenderer_AttackButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Index ---
		void Gameplay_Chat_View_VisitorItemRenderer__get_Index(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (param2 != *(uint *)(param1 + 0x38)) {
		    *(uint *)(param1 + 0x38) = param2;
		    iVar1 = 0x24;
		    if ((param2 & 1) == 0) {
		      iVar1 = 0x28;
		    }
		    func_ii_7050(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1 + iVar1),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Index ---
		void Gameplay_Chat_View_VisitorItemRenderer__set_Index(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57af2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57af2 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x228);
		        goto code_r0x80e218cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2d);
		code_r0x80e218cc:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_DuelManager__Init
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x40) + 0x18),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Chat_View_VisitorItemRenderer__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x40)) {
		    *(int *)(param1 + 0x40) = param2;
		    Gameplay_Chat_View_VisitorItemRenderer__set_Title(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Title ---
		void Gameplay_Chat_View_VisitorItemRenderer__get_Title
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x44),param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x44) = param2;
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x18),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Title ---
		void Gameplay_Chat_View_VisitorItemRenderer__set_Title(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint uVar7;
		  int iVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57af3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2344);
		    DAT_ram_00a57af3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x40) != 0) {
		    iVar4 = *(int *)(*(int *)(param1 + 0x40) + 0x14);
		    if (((*(byte *)(iVar4 + 0x14) & 1) == 0) || (*(int *)(iVar4 + 0x18) == 0)) {
		      uVar5 = *(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x18);
		    }
		    else {
		      uVar5 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (StringLiteral_2344,*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x18),0);
		    }
		    iVar4 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x44),uVar5,0);
		    if (iVar4 == 0) {
		      *(undefined4 *)(param1 + 0x44) = uVar5;
		      iVar4 = **(int **)(param1 + 0x18);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (*(int **)(param1 + 0x18),uVar5,*(undefined4 *)(iVar4 + 0x2d4));
		    }
		    piVar6 = *(int **)(param1 + 0x1c);
		    local_4 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x40) + 0x14) + 0xc) + 0x20);
		    iVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    if (iVar4 == 0) {
		      iVar4 = StringLiteral_5;
		    }
		    iVar8 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		              (piVar6,iVar4,*(undefined4 *)(iVar8 + 0x2d4));
		    uVar5 = *(undefined4 *)(param1 + 0x14);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar6;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x80e1f63e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e1f63e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                      (uVar3,*(undefined4 *)
		                              (*(int *)(*(int *)(*(int *)(param1 + 0x40) + 0x14) + 0xc) + 0x24),0);
		    uVar3 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar3,0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar5,uVar3,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    uVar1 = 1;
		    iVar4 = *(int *)(*(int *)(param1 + 0x40) + 0x14);
		    uVar7 = *(uint *)(iVar4 + 0x14);
		    if (((uVar7 & 1) == 0) || (*(int *)(iVar4 + 0x18) == 0)) {
		      uVar1 = (uVar7 & 2) >> 1;
		    }
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar1,0);
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar1 ^ 1,0);
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    iVar4 = *(int *)(*(int *)(param1 + 0x40) + 8);
		    if (iVar4 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = (uint)(*(char *)(iVar4 + 0x18) != '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar1,0);
		    iVar4 = *(int *)(*(int *)(param1 + 0x40) + 0x14);
		    uVar1 = *(uint *)(iVar4 + 0x14);
		    if ((uVar1 & 2) == 0) {
		      if ((uVar1 & 1) == 0) {
		        return;
		      }
		      if (*(int *)(iVar4 + 0x18) == 0) {
		        return;
		      }
		      iVar4 = 0x30;
		    }
		    else {
		      iVar4 = 0x2c;
		    }
		    func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + iVar4),0);
		  }
		  return;
		}
		*/

}
