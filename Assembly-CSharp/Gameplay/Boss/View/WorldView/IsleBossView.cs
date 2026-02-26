using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Boss.View.WorldView
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	public class IsleBossView : BaseIsleMonsterView, IToolTipDataProvider
	{
		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD0")]
		public Canvas Canvas
		{
			[Token(Token = "0x6004622")]
			[Address(RVA = "0x94BB", Offset = "0x94BB", VA = "0x94BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD1")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004623")]
			[Address(RVA = "0x94BC", Offset = "0x94BC", VA = "0x94BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD2")]
		public TextMeshProUGUI HealthLabel
		{
			[Token(Token = "0x6004624")]
			[Address(RVA = "0x94BD", Offset = "0x94BD", VA = "0x94BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DD3")]
		public ProgressBar ProgressBar
		{
			[Token(Token = "0x6004625")]
			[Address(RVA = "0x94BE", Offset = "0x94BE", VA = "0x94BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD4")]
		public BossInstance BossInstance
		{
			[Token(Token = "0x6004626")]
			[Address(RVA = "0x94BF", Offset = "0x94BF", VA = "0x94BF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004627")]
			[Address(RVA = "0x94C0", Offset = "0x94C0", VA = "0x94C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x94C1", Offset = "0x94C1", VA = "0x94C1")]
		public void Init(BossInstance instance)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Boss_View_WorldView_IsleBossView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  Gameplay_Isles_User_View_BaseIsleMonsterView__Dispose(param1,0);
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined8 *)(param1 + 0x3c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x94C2", Offset = "0x94C2", VA = "0x94C2", Slot = "11")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4 Gameplay_Boss_View_WorldView_IsleBossView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__IsleBossView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_ArtikulStackSize___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_ToolTip_Implementations_VO_Monster_IslandBossMonsterToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12534);
		    DAT_ram_00a579b4 = '\x01';
		  }
		  iVar6 = Method_System_Array_Empty_ArtikulStackSize___;
		  uVar4 = *(undefined4 *)
		           (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x3c) + 8) + 0x30) + 0x14) + 0xc);
		  iVar5 = *(int *)(Method_System_Array_Empty_ArtikulStackSize___ + 0x1c);
		  if (iVar5 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_ArtikulStackSize___);
		    iVar5 = *(int *)(iVar6 + 0x1c);
		  }
		  iVar5 = *(int *)(iVar5 + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  if (*(int *)(iVar5 + 0x74) == 0) {
		    func_ii_306000(iVar5);
		  }
		  iVar6 = *(int *)(*(int *)(iVar6 + 0x1c) + 8);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  uVar7 = **(undefined4 **)(iVar6 + 0x5c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e0e678;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0e678:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  uVar4 = Core_Data_MonsterData__Create(uVar4,uVar7,uVar3,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x40) + 8) + 8);
		  iVar6 = *(int *)(param1 + 0x3c);
		  param2_00 = *(undefined4 *)(*(int *)(iVar6 + 8) + 0xc);
		  uVar7 = unnamed_function_1417
		                    (UI_ToolTip_Implementations_VO_Monster_IslandBossMonsterToolTipVO_TypeInfo);
		  UI_ToolTip_Implementations_VO_Monster_AbstractMonsterToolTipVO___ctor
		            (uVar7,param2_00,uVar3,uVar4,iVar6,0);
		  uVar4 = unnamed_function_1417(UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO__TypeInfo);
		  UI_ToolTip_ToolTipData_object____ctor
		            (uVar4,StringLiteral_12534,uVar7,
		             Method_UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO___ctor__);
		  return uVar4;
		}
		*/

		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600462A")]
		[Address(RVA = "0x94C3", Offset = "0x94C3", VA = "0x94C3", Slot = "12")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462B")]
		[Address(RVA = "0x94C4", Offset = "0x94C4", VA = "0x94C4")]
		public IsleBossView()
		{
		}

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ProgressBar _progressBar;

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _healthLabel;

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x40")]
		private IsleBossViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_BossInstance ---
		void Gameplay_Boss_View_WorldView_IsleBossView__set_BossInstance
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_IsleBossViewMediator_TypeInfo);
		    DAT_ram_00a579b3 = '\x01';
		  }
		  *(int *)(param1 + 0x3c) = param2;
		  param4 = *(undefined4 *)(param2 + 0xc);
		  param3_00 = *(undefined4 *)(param2 + 0x10);
		  param2_00 = *(undefined4 *)(param2 + 8);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_Boss_Controller_IsleBossViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossWindowMediator___c___ValidateTabCounters_b__9_1
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
