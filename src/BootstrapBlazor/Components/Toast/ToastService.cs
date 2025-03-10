﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace BootstrapBlazor.Components;

/// <summary>
/// Toast 弹出窗服务类
/// </summary>
/// <remarks>
/// 构造方法
/// </remarks>
/// <param name="options"></param>
public class ToastService(IOptionsMonitor<BootstrapBlazorOptions> options) : BootstrapServiceBase<ToastOption>
{
    /// <summary>
    /// Show 方法
    /// </summary>
    /// <param name="option"></param>
    /// <param name="ToastContainer">指定弹窗组件 默认为 null 使用 <see cref="BootstrapBlazorRoot"/> 组件内置弹窗组件</param>
    public async Task Show(ToastOption option, ToastContainer? ToastContainer = null)
    {
        if (!option.ForceDelay && options.CurrentValue.ToastDelay != 0)
        {
            option.Delay = options.CurrentValue.ToastDelay;
        }
        await Invoke(option, ToastContainer);
    }
}
