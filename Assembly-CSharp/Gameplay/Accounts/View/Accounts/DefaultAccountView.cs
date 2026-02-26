using System;
using AssetContent;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.View.Accounts
{
	// Token: 0x02000DD7 RID: 3543
	[Token(Token = "0x2000DD7")]
	public class DefaultAccountView : AbstractAccountView
	{
		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001191")]
		public TextMeshProUGUI ActionTitle
		{
			[Token(Token = "0x600565B")]
			[Address(RVA = "0xA3E8", Offset = "0xA3E8", VA = "0xA3E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001192")]
		public Transform ActiveBlock
		{
			[Token(Token = "0x600565C")]
			[Address(RVA = "0xA3E9", Offset = "0xA3E9", VA = "0xA3E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001193")]
		public BacktimeViewUGUI ActiveBacktime
		{
			[Token(Token = "0x600565D")]
			[Address(RVA = "0xA3EA", Offset = "0xA3EA", VA = "0xA3EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600565E RID: 22110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001194")]
		public GameRawImage Image
		{
			[Token(Token = "0x600565E")]
			[Address(RVA = "0xA3EB", Offset = "0xA3EB", VA = "0xA3EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001195")]
		public OptionBuyButtonItem OptionViewPrefab
		{
			[Token(Token = "0x600565F")]
			[Address(RVA = "0xA3EC", Offset = "0xA3EC", VA = "0xA3EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001196")]
		public Transform OptionsContainer
		{
			[Token(Token = "0x6005660")]
			[Address(RVA = "0xA3ED", Offset = "0xA3ED", VA = "0xA3ED")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001197")]
		public GameRawImage SaleRibbon
		{
			[Token(Token = "0x6005661")]
			[Address(RVA = "0xA3EE", Offset = "0xA3EE", VA = "0xA3EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005662")]
		[Address(RVA = "0xA3EF", Offset = "0xA3EF", VA = "0xA3EF", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_View_Accounts_DefaultAccountView__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  uint *puVar1;
		  uint uVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a588a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		    DAT_ram_00a588a8 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x2c),0);
		  param1_01 = *(int **)(param1 + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8))
		      {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f39d5c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f39d5c:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005663")]
		[Address(RVA = "0xA3F0", Offset = "0xA3F0", VA = "0xA3F0", Slot = "8")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Accounts_View_Accounts_DefaultAccountView__HandleDataChanged
		               (int *param1,int *param2,int param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  undefined4 param4_00;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a588a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountViewMediator_TypeInfo);
		    DAT_ram_00a588a9 = '\x01';
		  }
		  if (param3 != param1[10]) {
		    param1[10] = param3;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x104));
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  param1_00 = unnamed_function_1417(Gameplay_Accounts_Control_AccountViewMediator_TypeInfo);
		  if (DAT_ram_00a588cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		    DAT_ram_00a588cb = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		  *(undefined4 *)(param1_00 + 0x18) = param1_01;
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4_00,param2,
		             Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView___ctor__
		            );
		  param1[0x12] = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005664")]
		[Address(RVA = "0xA3F1", Offset = "0xA3F1", VA = "0xA3F1", Slot = "7")]
		public override void Init(AccountsController controller, IAccountDataDecorator data)
		{
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005665")]
		[Address(RVA = "0xA3F2", Offset = "0xA3F2", VA = "0xA3F2")]
		public DefaultAccountView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Accounts_View_Accounts_DefaultAccountView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_ManufactureViewInAccountView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a588aa = '\x01';
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    return *(undefined4 *)(param1 + 0x54);
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x50);
		  param1_00 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(param1_00,uVar1,
		                       Method_UnityEngine_Object_Instantiate_ManufactureViewInAccountView___);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002ED9 RID: 11993
		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Transform _activeBlock;

		// Token: 0x04002EDA RID: 11994
		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected BacktimeViewUGUI _activeBacktime;

		// Token: 0x04002EDB RID: 11995
		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected TextMeshProUGUI _actionTitle;

		// Token: 0x04002EDC RID: 11996
		[Token(Token = "0x4002EDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected GameRawImage _image;

		// Token: 0x04002EDD RID: 11997
		[Token(Token = "0x4002EDD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected OptionBuyButtonItem _optionViewPrefab;

		// Token: 0x04002EDE RID: 11998
		[Token(Token = "0x4002EDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform _optionsContainer;

		// Token: 0x04002EDF RID: 11999
		[Token(Token = "0x4002EDF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected GameRawImage _saleRibbon;

		// Token: 0x04002EE0 RID: 12000
		[Token(Token = "0x4002EE0")]
		[FieldOffset(Offset = "0x48")]
		private AccountViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SaleRibbon ---
		void Gameplay_Accounts_View_Accounts_DefaultAccountView__get_SaleRibbon
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x28) = 0;
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

}
