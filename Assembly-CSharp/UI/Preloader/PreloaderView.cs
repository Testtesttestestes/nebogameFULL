using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Preloader
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public class PreloaderView : MonoBehaviour
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		public PreloaderView.PreloaderInfo Info
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x5F3D", Offset = "0x5F3D", VA = "0x5F3D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x5F3E", Offset = "0x5F3E", VA = "0x5F3E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x5F3F", Offset = "0x5F3F", VA = "0x5F3F")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Preloader_PreloaderView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a63904 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12173);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8652);
		    DAT_ram_00a63904 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (DAT_ram_00a63906 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Preloader_PreloaderView__ChangeTitleRoutine_d__22_TypeInfo);
		    DAT_ram_00a63906 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Preloader_PreloaderView__ChangeTitleRoutine_d__22_TypeInfo);
		  *(int *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar1,0);
		  piVar3 = *(int **)(param1 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_8652,1,0,1,0,0,0,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0x1c);
		  uVar2 = func_ii_7508(StringLiteral_12173,1,0,1,0,0,0,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x5F40", Offset = "0x5F40", VA = "0x5F40")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void UI_Preloader_PreloaderView__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  UnityEngine_MonoBehaviour__StopCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x5F41", Offset = "0x5F41", VA = "0x5F41")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_Preloader_PreloaderView__OnDisable(int param1,float param2,undefined4 param3)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  double dVar4;
		  double param1_00;
		  int iVar5;
		  ulonglong uVar6;
		  int local_c;
		  float8 local_8;
		  
		  if (DAT_ram_00a63905 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    DAT_ram_00a63905 = '\x01';
		  }
		  if (DAT_ram_00a6445d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6445d = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_00 = (double)(param2 * 100.0);
		  dVar1 = param1_00;
		  dVar4 = unnamed_function_4206(param1_00,&local_8);
		  if (0.0 <= param2 * 100.0) {
		    if (dVar4 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar6 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar6 = 0;
		      }
		      if ((uVar6 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + 1.0);
		      }
		    }
		    else {
		      local_8 = (float8)FLOOR(param1_00 + 0.5);
		    }
		  }
		  else if (dVar4 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar6 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar6 = 0;
		    }
		    if ((uVar6 & 1) != 0) {
		      local_8 = (float8)((double)local_8 + -1.0);
		    }
		  }
		  else {
		    local_8 = (float8)CEIL(param1_00 + -0.5);
		  }
		  if (ABS((double)local_8) < 2147483648.0) {
		    local_c = (int)(double)local_8;
		  }
		  else {
		    local_c = -0x80000000;
		  }
		  uVar2 = (undefined4)((ulonglong)dVar1 >> 0x20);
		  uVar3 = func_ii_4443(&local_c,0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,StringLiteral_708,0);
		  iVar5 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x118) * 4))
		            (CONCAT44(uVar2,*(int **)(param1 + 0x20)),uVar3,*(undefined4 *)(iVar5 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x5F42", Offset = "0x5F42", VA = "0x5F42")]
		private void DisplayTextProgress(float progress)
		{
		/* --- GHIDRA: DisplayTextProgress ---
		int UI_Preloader_PreloaderView__DisplayTextProgress
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63906 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Preloader_PreloaderView__ChangeTitleRoutine_d__22_TypeInfo);
		    DAT_ram_00a63906 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Preloader_PreloaderView__ChangeTitleRoutine_d__22_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x5F43", Offset = "0x5F43", VA = "0x5F43")]
		private IEnumerator ChangeTitleRoutine(TextMeshProUGUI title)
		{
		/* --- GHIDRA: ChangeTitleRoutine ---
		void UI_Preloader_PreloaderView__ChangeTitleRoutine(int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  float param1_00;
		  float param3_00;
		  float param2_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63907 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Preloader_PreloaderView_DisplayTextProgress__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a63907 = '\x01';
		  }
		  param1_00 = *(float *)(param1 + 0x38);
		  *(float *)(param1 + 0x38) = param2;
		  iVar2 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x108) * 4))
		            (*(int **)(param1 + 0x20),param2,*(undefined4 *)(iVar2 + 0x10c));
		  if (*(int *)(param1 + 0x3c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x3c),0,0);
		  }
		  param3_00 = *(float *)(param1 + 0x2c);
		  param2_01 = *(float *)(param1 + 0x38);
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_float__TypeInfo);
		  DG_Tweening_TweenCallback_int___Invoke
		            (uVar1,param1,Method_UI_Preloader_PreloaderView_DisplayTextProgress__,0);
		  uVar1 = DG_Tweening_DOTween___c__DisplayClass67_0___To_b__1(param1_00,param2_01,param3_00,uVar1,0)
		  ;
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x5F44", Offset = "0x5F44", VA = "0x5F44")]
		private void SetProgress(float value)
		{
		/* --- GHIDRA: SetProgress ---
		void UI_Preloader_PreloaderView__SetProgress(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(int **)(param1 + 0x40) = param2;
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xd8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xdc));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		/* --- GHIDRA: SetProgress ---
		void UI_Preloader_PreloaderView__SetProgress(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(int **)(param1 + 0x40) = param2;
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xd8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xdc));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x5F45", Offset = "0x5F45", VA = "0x5F45")]
		public void SetProgress(float current, float total)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x5F46", Offset = "0x5F46", VA = "0x5F46")]
		public void SetInfo(PreloaderView.PreloaderInfo info)
		{
		/* --- GHIDRA: SetInfo ---
		void UI_Preloader_PreloaderView__SetInfo(int param1,undefined4 param2,undefined4 param3)
		
		{
		  func_ii_8025(*(undefined4 *)(param1 + 0x30),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x5F47", Offset = "0x5F47", VA = "0x5F47")]
		public void SetOverrideBackground(Sprite sprite)
		{
		/* --- GHIDRA: SetOverrideBackground ---
		void UI_Preloader_PreloaderView__SetOverrideBackground
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = **(int **)(param1 + 0x34);
		  local_8 = param2[1];
		  local_10 = *param2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x34),&local_10,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x5F48", Offset = "0x5F48", VA = "0x5F48")]
		public void SetBackgroundColor(Color value)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x5F49", Offset = "0x5F49", VA = "0x5F49")]
		public PreloaderView()
		{
		}

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleTextField;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _infoTextField;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _helpButtonLabel;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _progressLabel;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithText _progressBar;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PreloaderView.LocaleKeys _titles;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _titleChangePeriod;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _progressTweenDuration;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _background;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _paintableBackgound;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x38")]
		private float _progress;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x3C")]
		private Tweener _progressTween;

		// Token: 0x020001D2 RID: 466
		[Token(Token = "0x20001D2")]
		public class PreloaderInfo
		{
			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00003E10 File Offset: 0x00002010
			// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000196")]
			public ulong UserId
			{
				[Token(Token = "0x6000C3B")]
				[Address(RVA = "0x5F4A", Offset = "0x5F4A", VA = "0x5F4A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6000C3C")]
				[Address(RVA = "0x5F4B", Offset = "0x5F4B", VA = "0x5F4B")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x5F4C", Offset = "0x5F4C", VA = "0x5F4C")]
			public PreloaderInfo(AppBuildInfo appBuildInfo, string separator)
			{
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x5F4D", Offset = "0x5F4D", VA = "0x5F4D", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			[FieldOffset(Offset = "0x10")]
			private readonly AppBuildInfo _appBuildInfo;

			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			[FieldOffset(Offset = "0x14")]
			private readonly string _separator;
		}

		// Token: 0x020001D3 RID: 467
		[Token(Token = "0x20001D3")]
		[Serializable]
		public class LocaleKeys
		{
			// Token: 0x06000C3F RID: 3135 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x5F4E", Offset = "0x5F4E", VA = "0x5F4E")]
			public string GetText(string language)
			{
				return null;
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x5F4F", Offset = "0x5F4F", VA = "0x5F4F")]
			public LocaleKeys()
			{
			}

			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _localeKey;

			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			[FieldOffset(Offset = "0xC")]
			private string _language;

			// Token: 0x040005E6 RID: 1510
			[Token(Token = "0x40005E6")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<string> _rows;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Info ---
		void UI_Preloader_PreloaderView__set_Info(int param1,undefined4 param2)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63903 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a63903 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),StringLiteral_5,*(undefined4 *)(iVar1 + 0x2d4));
		  param2_00 = UnityEngine_Camera__set_orthographicSize(0.0,1.0,0);
		  UI_Preloader_PreloaderView__ChangeTitleRoutine(param1,param2_00,param1);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

}
